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

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings, long bound)
        {
            long mix = 786;
            foreach (long entry in readings)
            {
                if (mix > (bound - mix))
                {
                    mix = (mix ^ entry) % 97;
                }
                else
                {
                    mix = ((mix * 4) + mix) % 65521;
                }
            }
            return mix % 65521;
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
