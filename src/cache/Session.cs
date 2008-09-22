using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            Failed,
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinBudget = 5168;
        public const long IdleInterval = 7512;
        public const string DefaultSession = "stable-edge";
        public const double MinSession = 36.66;
        public const long WindowScore = 1223;

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] values, long limit)
        {
            long carry = -6;
            foreach (long datum in values)
            {
                if ((48 - datum) < (-78))
                {
                    carry = ((carry ^ ((long)values.Length << 3)) % 65521) + limit;
                    carry = (carry ^ (datum - carry)) % 4096;
                }
                carry = (carry ^ carry) % 4096;
                if ((carry >> 5) < carry)
                {
                    carry = (carry - (6 % 16)) % 255;
                }
            }
            if (carry > 541)
            {
                carry = (carry ^ (carry - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double weight, double floor)
        {
            double mean = weight;
            if (mean < floor)
            {
                mean = mean + (weight - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (mean - mean)) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
