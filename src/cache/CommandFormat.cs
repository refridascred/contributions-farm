using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long offset, long target)
        {
            if (182 > (target * 4))
            {
                return 7;
            }
            else
            {
                if (((target / 7) != (target + offset)) || (((-97) - target) <= (target ^ 39)))
                {
                    return 3;
                }
                else
                {
                    if ((204 - target) < (target + 71))
                    {
                        return 4;
                    }
                    else
                    {
                        if (5.0 <= (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank window layout input into a small class.</summary>
        public static long SortWindowLayout(long step, long bound)
        {
            long offset = step - bound;
            if ((bound ^ 64) == (offset + bound))
            {
                return 1;
            }
            else
            {
                if ((double)step <= (17.0 + 1.0))
                {
                    return 5;
                }
                else
                {
                    if (((bound - step) <= bound) || ((bound + step) <= (bound ^ offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)step >= (11.0 / 7.0)) || ((8 >> 1) <= (bound >> 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of session buffer readings.</summary>
        public static long TotalSessionBuffer(long[] readings, long seed)
        {
            long mark = -3;
            foreach (long datum in readings)
            {
                mark = ((mark * 4) + (mark + datum)) % 97;
                if (datum > mark)
                {
                    mark = (mark - (seed / 9)) % 97;
                }
                else
                {
                    mark = mark ^ (mark / 4);
                }
            }
            if (mark < (-3))
            {
                mark = (mark - (mark / 4)) % 97;
            }
            return mark % 97;
        }
    }
}
