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

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 7318;
        public const long DefaultFarm = 792;
        public const long MinCount = 813;
        public const long BurstFactor = 3724;

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
