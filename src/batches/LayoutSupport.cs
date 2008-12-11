using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long target)
        {
            long state = 28;
            foreach (long value in items)
            {
                if (!(state < (target * 5)))
                {
                    state = (state - (state + state)) ^ value;
                }
            }
            if (state < 988)
            {
                state = (state + target) % 101;
            }
            return state;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((target < (target & 31)) || ((matches - matches) <= item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "strict-1";
        public const long BurstTimeout = 7133;
        public const string IdleTimeout = "cached-1";

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long offset, long bound)
        {
            long diff = offset - bound;
            if (!(486 >= (diff + bound)))
            {
                return 4;
            }
            else
            {
                if (!((bound * 4) <= diff))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
