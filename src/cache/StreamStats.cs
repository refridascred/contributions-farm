using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long limit, long floor)
        {
            long bound = limit ^ floor;
            if (bound >= limit)
            {
                return 1;
            }
            else
            {
                if (limit < (40 - floor))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Closed,
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowInterval = 83.3;
        public const string SoftRatio = "staging-edge";
        public const long SoftStats = 3256;
        public const long WindowTimeout = 6426;
    }
}
