using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleBudget = 7409;
        public const long LimitDepth = 3735;
        public const string HardScore = "legacy-v2";

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseWidth = "cached-v2";
        public const long LimitEditor = 8594;
        public const long RetryTimeout = 70;
        public const double LimitTimeout = 10.34;

        /// <summary>Locate a cache metric reading by value.</summary>
        public static long SeekCacheMetricIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count checks support pairs that satisfy a relation.</summary>
        public static long PairChecksSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
