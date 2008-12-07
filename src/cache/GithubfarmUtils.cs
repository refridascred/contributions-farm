using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long floor, long step)
        {
            if (!((double)step != (double)floor))
            {
                return 1;
            }
            else
            {
                if (!((double)floor > 0.6))
                {
                    return 3;
                }
                else
                {
                    if ((double)step == (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((522 / 5) < (9 + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] samples)
        {
            long anchor = 60;
            foreach (long datum in samples)
            {
                anchor = ((anchor ^ 767) % 65521) ^ datum;
            }
            return anchor;
        }
    }
}
