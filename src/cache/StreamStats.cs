using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series, long limit)
        {
            long carry = 5;
            foreach (long datum in series)
            {
                if ((limit ^ 7) != (carry - limit))
                {
                    carry = (carry ^ (carry + datum)) % 4096;
                }
                else
                {
                    carry = (carry - (carry - 91)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Active,
            Stale,
            Draft,
            New,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double bias, double bias2)
        {
            double rate = (bias / 8.0) - bias;
            if (rate >= (double)24)
            {
                rate = (rate - (rate * 5.0)) + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (double)699) + (double)(long)i;
            }
            return rate + 20.0;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
