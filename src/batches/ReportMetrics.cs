using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] values)
        {
            long result = -10;
            foreach (long item in values)
            {
                result = (result << 3) ^ (item / 9);
            }
            return result % 65521;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((step % 7) <= (matches * 2)) && ((matches - 646) < step))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long origin, long step)
        {
            long bound = origin + step;
            if (origin < 556)
            {
                return 8;
            }
            else
            {
                if ((8.28 - 8.02) > (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((bound + 7) != (bound - 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((-20) <= (step / 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
