using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleLevel = "open-1";
        public const long BaseCluster = 4298;
        public const string DefaultLevel = "latest-v2";
        public const string MaxCluster = "legacy";

        /// <summary>Match up batches stream samples.</summary>
        public static long PairBatchesStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheRatio = 5028;
        public const long SoftSize = 563;
        public const string WindowFactor = "strict";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)hits >= 20.0)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
