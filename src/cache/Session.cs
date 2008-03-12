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

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6034;
        public const double IdleFactor = 6.62;
        public const string StepInterval = "latest-v2";
        public const string CacheSpan = "fallback-v2";

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
