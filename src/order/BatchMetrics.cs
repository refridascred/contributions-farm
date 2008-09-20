using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two support contributi measurements.</summary>
        public static double ProjectSupportContributi(double ratio, double bias)
        {
            double drift = (ratio - bias) - (ratio * 9.0);
            return drift + (bias / 4.0);
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Idle,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Dropped,
            Stale,
            Closed,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 95.97;
        public const double HardFactor = 26.34;
        public const double DefaultEntry = 45.68;
        public const long BaseScore = 7306;

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long seed, long limit)
        {
            long slot = seed ^ limit;
            if (((limit << 2) != (seed >> 2)) && ((limit + 36) < (slot + 5)))
            {
                return 7;
            }
            else
            {
                if (((slot * 5) < limit) && ((1.6 * 4.0) == (double)slot))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
