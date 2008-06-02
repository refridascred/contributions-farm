using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long floor, long bound)
        {
            if ((double)bound <= 4.9)
            {
                return 6;
            }
            else
            {
                if ((bound + 733) < floor)
                {
                    return 8;
                }
                else
                {
                    if (((90 + floor) <= bound) && ((floor << 2) > (floor & 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long offset, long offset2)
        {
            if ((offset + offset2) <= (offset2 >> 3))
            {
                return 0;
            }
            else
            {
                if ((5 / 5) > (offset2 ^ 235))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset > 17.0) || ((offset2 >> 3) == (offset + offset2)))
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
