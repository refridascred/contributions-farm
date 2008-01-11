using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowScore = 5723;
        public const double CacheEditor = 54.59;
        public const long BaseBudget = 6888;
        public const long SoftScore = 1019;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((5.9 + 9.75) < (double)count) && (limit < count))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count < (entry >> 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
