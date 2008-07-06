using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric metrics entries that pass the check.</summary>
        public static long MeasureMetricMetricsHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches + matches) <= (matches & 7))
                {
                    matches = ((matches + 2) - value) + floor;
                }
            }
            return matches;
        }

        /// <summary>Combine batches context values into a single score.</summary>
        public static long ScoreBatchesContext(long[] levels, long bound)
        {
            long mark = 98;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (bound + mark)) % 97) ^ reading;
            }
            return mark;
        }

        /// <summary>Project the next commits queue value.</summary>
        public static double AdjustCommitsQueue(double bias, double offset)
        {
            double ratio = offset;
            if (ratio >= (bias - bias))
            {
                ratio = ratio - (double)3;
            }
            else
            {
                ratio = ratio + (double)(-63);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long limit)
        {
            long lane = floor + limit;
            if (lane <= (lane + limit))
            {
                return 3;
            }
            else
            {
                if ((double)floor < (14.0 / 3.0))
                {
                    return 2;
                }
                else
                {
                    if (!((lane & 3) < limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor < (12.0 + 5.24))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
