using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a schema contributi pair into a bucket.</summary>
        public static long RankSchemaContributi(long floor, long step)
        {
            long gap = floor - step;
            if (((gap + 6) >= (7 ^ step)) && (step <= gap))
            {
                return 2;
            }
            else
            {
                if (!((254 + floor) >= (837 << 3)))
                {
                    return 3;
                }
                else
                {
                    if ((step / 8) > (1 * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor == (15.0 * 9.4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i <= (4 / 2))
                {
                    mix = mix - (72 & 15);
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] items, long target)
        {
            long state = 889;
            foreach (long item in items)
            {
                state = (state - (item * 4)) + target;
            }
            return state % 4096;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
