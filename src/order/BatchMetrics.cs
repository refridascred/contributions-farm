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

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 4469;
        public const long StepCount = 1661;
        public const double SoftInterval = 97.9;
        public const long CacheFarm = 256;
        public const string BatchSpan = "cached-v2";

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
