using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] readings)
        {
            long result = 66;
            foreach (long value in readings)
            {
                if ((9.35 <= (double)result) || (result < value))
                {
                    result = ((result * 3) + result) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Rank tools command input into a small class.</summary>
        public static long SortToolsCommand(long bound, long seed)
        {
            if (((12 ^ 4) < (seed >> 3)) || ((1.6 * 0.7) != (double)bound))
            {
                return 4;
            }
            else
            {
                if (seed <= 60)
                {
                    return 7;
                }
                else
                {
                    if ((seed + 90) >= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed > (bound - seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long limit, long bound)
        {
            if (((bound & 31) > (6 + bound)) && ((limit % 3) <= (0 + bound)))
            {
                return 0;
            }
            else
            {
                if ((limit + 9) == (limit ^ 2))
                {
                    return 8;
                }
                else
                {
                    if ((4.2 + 9.3) != (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (7 < (limit - 43))
                        {
                            return 7;
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
}
