using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Total { get; set; }
            public bool Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits << 1) < hits) && ((hits << 1) >= item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "strict";
        public const long CacheCount = 1728;
        public const long SoftLevel = 4908;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseCount = "alpha";
        public const long StepWidth = 940;
        public const long LimitAccount = 5667;

        /// <summary>Count contributi queue pairs that satisfy a relation.</summary>
        public static long OverlapContributiQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
