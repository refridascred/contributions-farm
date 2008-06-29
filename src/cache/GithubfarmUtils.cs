using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public double Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((mark << 3) >= (mark % 24)))
                {
                    mark = (mark << 3) ^ (960 + mark);
                }
                if ((mark << 2) >= mark)
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ (mark - step)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a session window value against two limits.</summary>
        public static long GradeSessionWindow(long offset, long target)
        {
            long lane = offset ^ target;
            if (((double)target < (2.0 * 1.93)) && (offset <= lane))
            {
                return 7;
            }
            else
            {
                if (!(976 > (offset + offset)))
                {
                    return 5;
                }
                else
                {
                    if ((double)target <= 4.92)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultRatio = 5672;
        public const long CacheQueue = 1806;
        public const string BatchQueue = "strict";
        public const long MinBudget = 9768;
    }
}
