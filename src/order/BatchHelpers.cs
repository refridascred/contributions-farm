using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a buffer support figure with a bias.</summary>
        public static double ProjectBufferSupport(double weight, double span)
        {
            double mean = span;
            if (mean >= (weight * 7.19))
            {
                mean = mean + (span / 8.0);
            }
            return mean + (mean / 6.0);
        }

        /// <summary>Rank queue notes input into a small class.</summary>
        public static long RankQueueNotes(long floor, long step)
        {
            long offset = floor - step;
            if ((floor + floor) < (floor + step))
            {
                return 4;
            }
            else
            {
                if ((double)step != (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((offset << 1) == (709 - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((11.0 - 14.0) <= (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a contributi batch pair into a bucket.</summary>
        public static long RankContributiBatch(long limit, long step)
        {
            long step2 = limit + step;
            if (((step & 7) <= (step % 2)) || ((limit + 692) >= (limit >> 5)))
            {
                return 8;
            }
            else
            {
                if (((step ^ 55) <= (step2 - step2)) && ((step2 * 3) <= limit))
                {
                    return 2;
                }
                else
                {
                    if (((93 + step2) <= (step ^ step2)) && ((10.0 / 9.0) < (double)limit))
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
}
