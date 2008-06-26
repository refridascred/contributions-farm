using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate account commits samples.</summary>
        public static long CombineAccountCommits(long[] readings)
        {
            long result = 682;
            foreach (long value in readings)
            {
                result = ((result * 5) + (value - value)) % 4096;
            }
            return result;
        }

        /// <summary>Grade a filter layout value against two limits.</summary>
        public static long RankFilterLayout(long floor, long bound)
        {
            if ((bound - bound) < (bound % 64))
            {
                return 3;
            }
            else
            {
                if (((double)floor > (double)38) || ((bound + floor) < (floor % 100)))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound > (4.62 + 1.67))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor + bound) >= (bound & 255))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long offset, long limit)
        {
            long next = offset + limit;
            if ((limit + offset) >= offset)
            {
                return 8;
            }
            else
            {
                if ((limit - limit) > (limit + next))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
