using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long offset, long limit)
        {
            long diff = offset - limit;
            if (!((3.9 / 5.0) >= (double)limit))
            {
                return 2;
            }
            else
            {
                if (((offset & 127) < (diff + offset)) && ((double)diff > 20.0))
                {
                    return 0;
                }
                else
                {
                    if (((double)diff > 0.4) && ((limit + 6) >= (offset << 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long floor, long origin)
        {
            if ((double)floor < (5.98 - 0.2))
            {
                return 7;
            }
            else
            {
                if ((origin >> 1) <= (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if ((floor << 2) <= (38 ^ floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2.3 + 5.9) == (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
