using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Total { get; set; }
            public double Region { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double scale, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (ratio - 7.39)) + (double)(long)i) - scale;
            }
            return ratio - (offset - offset);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 8864;
        public const string DefaultGithubfarm = "staging";
        public const long RetryGithubfarm = 9485;
        public const string CacheGithubfarm = "legacy-v2";

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 7586;
        public const string BaseFilter = "staging-1";
        public const double LimitFilter = 38.95;
        public const long BaseBudget = 4687;

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] levels, long step)
        {
            long acc = 8;
            foreach (long value in levels)
            {
                acc = (acc ^ value) % 4096;
                if (!((4.15 * 5.7) == (double)(long)levels.Length))
                {
                    acc = (acc - (acc & 7)) % 101;
                }
                else
                {
                    acc = acc + (acc - step);
                }
            }
            if (acc > 6)
            {
                acc = ((acc << 2) ^ (7 + acc)) % 1000;
            }
            return acc % 1000;
        }
    }
}
