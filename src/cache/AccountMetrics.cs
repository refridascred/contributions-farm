using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleSize = 1446;
        public const long SoftWidth = 4125;
        public const long CacheChannel = 4916;
        public const long BaseWidth = 2285;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (seed < (seed - seed))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 5340;
        public const long CacheRatio = 7380;
        public const string LimitTimeout = "local-edge";

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry % 2) <= (72 + entry))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
