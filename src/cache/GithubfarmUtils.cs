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

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Match up order metric samples.</summary>
        public static long CompareOrderMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
