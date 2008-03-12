using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long seed, long bound)
        {
            long delta = seed ^ bound;
            if (seed > (bound - delta))
            {
                return 5;
            }
            else
            {
                if (!((94 << 1) > (seed % 5)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 3) + (step << 3)) % 255;
                acc = ((acc << 3) ^ 800) % 255;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Retry,
            Synced,
            Draft,
        }
    }
}
