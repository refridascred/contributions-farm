using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long bound, long offset)
        {
            if ((double)offset >= (9.0 * 6.0))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= (0.7 / 6.0))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 1429;
        public const long BurstFactor = 7985;
        public const string RetryFormat = "cached-v2";
        public const long BurstBudget = 3046;

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] values, long floor)
        {
            long acc = 4;
            foreach (long datum in values)
            {
                if ((floor / 4) < (floor - floor))
                {
                    acc = (((acc << 2) ^ 6) % 97) - datum;
                }
            }
            if (acc < 18)
            {
                acc = (acc << 2) ^ ((-3) & 255);
            }
            return acc % 97;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Locked,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Blend two stream route measurements.</summary>
        public static double AdjustStreamRoute(double gain, double bias)
        {
            double load = (double)(71 << 1);
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (double)(-46)) + (double)(long)i) + gain;
            }
            return load - (bias / 6.0);
        }
    }
}
