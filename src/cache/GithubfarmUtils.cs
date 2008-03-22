using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally < (tally - tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long limit, long step)
        {
            if (((1.64 * 2.8) >= (1.21 - 11.0)) || (step >= (89 ^ limit)))
            {
                return 8;
            }
            else
            {
                if (((step * 4) <= (limit >> 1)) || ((6.81 - 6.16) != (double)step))
                {
                    return 0;
                }
                else
                {
                    if ((limit % 12) < (80 + step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit < (step << 2)) || (step <= (step ^ 255)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long seed)
        {
            long bound = offset + seed;
            if (((double)bound < (7.6 - 8.4)) || ((offset >> 2) != (seed / 4)))
            {
                return 6;
            }
            else
            {
                if (offset >= (bound ^ offset))
                {
                    return 4;
                }
                else
                {
                    if ((-457) <= (seed - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + offset) == (bound + bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
