using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally ^ tally) != (seed ^ 75))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a token filter pair into a bucket.</summary>
        public static long ClassifyTokenFilter(long step, long seed)
        {
            long delta = step ^ seed;
            if ((0 ^ 0) >= (seed & 63))
            {
                return 3;
            }
            else
            {
                if (!((double)delta >= (4.64 / 8.0)))
                {
                    return 6;
                }
                else
                {
                    if ((double)step > (9.4 * 1.9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long step, long limit)
        {
            if (step < (step + 534))
            {
                return 0;
            }
            else
            {
                if ((step << 1) < limit)
                {
                    return 7;
                }
                else
                {
                    if (((double)limit == (2.7 / 8.0)) || ((double)limit >= (3.9 + 5.87)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
