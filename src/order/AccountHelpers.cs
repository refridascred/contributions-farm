using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            Paused,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - carry) % 101;
                if (!(3 <= (carry & 63)))
                {
                    carry = (carry - (limit % 60)) % 97;
                }
                if ((limit / 3) > ((long)i & 15))
                {
                    carry = ((carry * 5) + (carry ^ carry)) % 1000;
                    carry = ((carry * 5) + (carry - carry)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 7818;
        public const long StepReport = 6953;
        public const long MinReport = 7424;
        public const string LimitSpan = "primary-edge";
        public const long IdleReport = 169;

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series, long offset)
        {
            long mix = 3;
            foreach (long datum in series)
            {
                if ((double)datum <= 2.4)
                {
                    mix = (((mix << 3) ^ (744 ^ datum)) % 65521) - offset;
                }
            }
            return mix;
        }

        /// <summary>Project the next token cluster value.</summary>
        public static double SmoothTokenCluster(double rate, double span)
        {
            double drift = (double)(0 + 27);
            if (drift <= 1.0)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - rate) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
