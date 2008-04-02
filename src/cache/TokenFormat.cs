using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((seen % 2) > (reading ^ offset)) && ((seen + 3) == (reading - seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long floor, long limit)
        {
            long span = floor - limit;
            if ((limit ^ span) > (limit + floor))
            {
                return 2;
            }
            else
            {
                if (span < (limit + floor))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Done,
            Pending,
            Locked,
        }
    }
}
