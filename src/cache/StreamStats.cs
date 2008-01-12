using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of cache channel readings.</summary>
        public static long CompareCacheChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftCache = 37.47;
        public const long BurstCache = 302;
        public const string StepCache = "cached-edge";

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Locked,
            Draft,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheContext = "latest-v2";
        public const string BatchScore = "latest-1";
        public const long CacheDepth = 1993;
    }
}
