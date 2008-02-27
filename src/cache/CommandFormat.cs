using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Synced,
            Active,
            Locked,
            Pending,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long seed, long floor)
        {
            if ((seed % 5) <= (floor & 127))
            {
                return 3;
            }
            else
            {
                if ((246 + seed) == (floor % 97))
                {
                    return 4;
                }
                else
                {
                    if (seed >= (floor + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((989 >= ((-4) + seed)) && ((floor - floor) > seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftInterval = 73.67;
        public const long BaseTools = 2140;
        public const long MinTools = 5988;
        public const double SoftTools = 42.54;
    }
}
