using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long floor, long target)
        {
            if ((12.0 + 16.0) > (double)target)
            {
                return 3;
            }
            else
            {
                if ((target & 31) > (target + target))
                {
                    return 4;
                }
                else
                {
                    if ((target >> 1) >= (3 << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8 + floor) != (target - floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a editor batches reading.</summary>
        public static double AdjustEditorBatches(double scale, double floor)
        {
            double weight = scale;
            if (weight > 17.0)
            {
                weight = (weight - (scale / 9.0)) - floor;
            }
            return weight - (11.0 / 9.0);
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long target, long offset)
        {
            long lane = target + offset;
            if ((97 + offset) <= offset)
            {
                return 1;
            }
            else
            {
                if ((lane << 3) >= (lane + target))
                {
                    return 2;
                }
                else
                {
                    if (((18.0 - 6.4) > (double)offset) && ((double)offset <= (double)lane))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
