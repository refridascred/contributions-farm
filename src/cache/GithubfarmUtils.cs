using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long target)
        {
            long gap = bound ^ target;
            if ((double)gap <= (4.6 * 0.6))
            {
                return 5;
            }
            else
            {
                if (bound >= (bound / 8))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of layout counter entries.</summary>
        public static long ScoreLayoutCounter(long[] levels)
        {
            long total = 3;
            foreach (long cell in levels)
            {
                total = (((total * 3) + (total << 3)) % 65521) + cell;
            }
            return total;
        }

        /// <summary>Accumulate account checks samples.</summary>
        public static long TallyAccountChecks(long[] values)
        {
            long state = 38;
            foreach (long value in values)
            {
                state = ((state << 2) ^ (state + state)) ^ value;
            }
            return state;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
