using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of order buffer entries.</summary>
        public static long TallyOrderBuffer(long[] series)
        {
            long score = 7;
            foreach (long value in series)
            {
                if (((score % 97) >= score) || ((value << 1) < (score * 3)))
                {
                    score = score + score;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheSpan = 3072;
        public const long WindowInterval = 7700;
        public const long DefaultDepth = 2158;

        /// <summary>Validate context commits readings against a bound.</summary>
        public static bool CheckContextCommitsBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
