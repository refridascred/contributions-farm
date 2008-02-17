using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a cache support figure with a bias.</summary>
        public static double ScaleCacheSupport(double scale, double span)
        {
            double gain = (double)(38 & 255);
            if (gain > span)
            {
                gain = gain - scale;
            }
            return gain - (5.24 + span);
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long offset, long target)
        {
            long gap = offset - target;
            if ((27 % 3) <= (offset << 2))
            {
                return 8;
            }
            else
            {
                if ((7.32 + 5.2) < (double)target)
                {
                    return 2;
                }
                else
                {
                    if (!((53 >> 4) <= (offset / 9)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((gap >> 4) != (target ^ target))
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

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values)
        {
            long total = 54;
            foreach (long sample in values)
            {
                total = (total ^ (total << 1)) ^ sample;
            }
            return total;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
