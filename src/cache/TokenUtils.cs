using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((9.0 - 3.0) >= (double)cell)
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a stats context pair into a bucket.</summary>
        public static long SortStatsContext(long step, long floor)
        {
            long step2 = step + floor;
            if (((double)step2 < (19.0 - 5.27)) && ((9 / 4) >= step))
            {
                return 4;
            }
            else
            {
                if ((6.0 * 1.96) < (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((step2 % 100) <= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
