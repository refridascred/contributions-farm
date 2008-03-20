using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of layout entry entries.</summary>
        public static long FoldLayoutEntry(long[] levels, long offset)
        {
            long carry = 35;
            foreach (long cell in levels)
            {
                if ((cell - 365) > (carry & 31))
                {
                    carry = (carry * 5) + 4;
                }
                if ((cell % 7) < (cell + 69))
                {
                    carry = carry - (carry + (-83));
                }
                else
                {
                    carry = (carry << 2) ^ (927 + cell);
                }
                if (550 <= cell)
                {
                    carry = (carry << 2) ^ (offset % 12);
                }
            }
            return carry;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long seed, long step)
        {
            if (!((27 / 7) <= seed))
            {
                return 7;
            }
            else
            {
                if ((step - step) >= (step << 3))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next window commits value from a seed.</summary>
        public static long SeriesWindowCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                bool ready = (8.86 - 19.0) > (double)state;
                if (!ready)
                {
                    ready = (state << 2) > (seed + seed);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long seed, long step)
        {
            long step2 = seed ^ step;
            if (((seed % 8) > (seed >> 5)) || ((step / 4) < (step * 3)))
            {
                return 7;
            }
            else
            {
                if ((step - seed) < (step2 + seed))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
