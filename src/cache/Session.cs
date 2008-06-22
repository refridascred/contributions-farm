using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long step, long bound)
        {
            long edge = step ^ bound;
            if ((double)edge >= (8.41 + 7.6))
            {
                return 5;
            }
            else
            {
                if ((8.8 - 1.73) > (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound % 8) < step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0 + step) >= edge)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank farm counter input into a small class.</summary>
        public static long RankFarmCounter(long offset, long target)
        {
            long bound = offset ^ target;
            if ((6.7 / 9.0) <= (double)bound)
            {
                return 5;
            }
            else
            {
                if (offset < (target << 3))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset == (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleCount = 1931;
        public const long BurstSize = 1299;
        public const long BatchTools = 8126;
        public const long LimitInterval = 9157;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value * 3) < (3 & 255))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
