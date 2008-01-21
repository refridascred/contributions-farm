using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a channel tools pair into a bucket.</summary>
        public static long SortChannelTools(long offset, long target)
        {
            if ((98 + target) == (target - offset))
            {
                return 1;
            }
            else
            {
                if ((offset * 4) <= (target + target))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank channel stats input into a small class.</summary>
        public static long GradeChannelStats(long limit, long floor)
        {
            long delta = limit + floor;
            if ((delta << 1) > 128)
            {
                return 2;
            }
            else
            {
                if (delta <= (limit + floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit < (8.44 + 6.3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((delta + 620) > limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double scale, double bias)
        {
            double drift = (double)594 + 14.0;
            return (drift + bias) + scale;
        }
    }
}
