using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = mark + 355;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark ^ (mark / 9)) % 255) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Rank layout notes input into a small class.</summary>
        public static long RankLayoutNotes(long seed, long bound)
        {
            long cur = seed + bound;
            if (((8 + 75) == (seed / 3)) && (2.35 >= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((seed <= 5) && ((double)seed == (1.07 + 0.02)))
                {
                    return 6;
                }
                else
                {
                    if (cur < seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((294 - bound) > (cur + cur)) || ((double)seed >= (1.65 - 20.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
