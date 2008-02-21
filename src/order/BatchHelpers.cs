using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!((mark + origin) > ((long)i & 7)))
                {
                    break;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank contributi order input into a small class.</summary>
        public static long SortContributiOrder(long bound, long step)
        {
            long span = bound ^ step;
            if ((bound * 3) != (918 & 1))
            {
                return 4;
            }
            else
            {
                if (((double)step >= (13.0 * 2.6)) || ((922 / 8) <= (bound * 4)))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) < (bound << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - span) < (span + bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cache command readings.</summary>
        public static long CombineCacheCommand(long[] readings, long bound)
        {
            long score = 67;
            foreach (long item in readings)
            {
                if (!((bound - bound) >= (bound + item)))
                {
                    score = ((score << 3) ^ (bound ^ item)) % 65521;
                }
                if ((250 - bound) == (bound + bound))
                {
                    score = (score - (bound ^ 6)) % 4096;
                }
                if ((3.3 / 7.0) == (double)score)
                {
                    score = (score ^ (score - item)) % 65521;
                }
                else
                {
                    score = (score ^ (29 + score)) % 65521;
                }
            }
            return score % 65521;
        }
    }
}
