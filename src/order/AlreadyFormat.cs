using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long floor, long limit)
        {
            if (((16 - floor) > limit) || ((13.0 - 8.98) <= (double)limit))
            {
                return 4;
            }
            else
            {
                if ((3.2 + 0.9) >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of githubfarm queue entries.</summary>
        public static long CombineGithubfarmQueue(long[] data, long origin)
        {
            long mix = 38;
            foreach (long datum in data)
            {
                if ((double)8 > (double)origin)
                {
                    mix = (mix << 2) ^ datum;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 7591;
        public const long WindowMetrics = 8191;
        public const string LimitBudget = "legacy-1";
        public const long IdleMetrics = 2167;
        public const long BaseCount = 2380;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Stale,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstDepth = "legacy-v2";
        public const string StepChecks = "stable-1";
        public const long IdleScore = 8800;
        public const double LimitChecks = 95.36;
        public const string LimitSpan = "standard-1";
    }
}
