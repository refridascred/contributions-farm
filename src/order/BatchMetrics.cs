using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings, long origin)
        {
            long mix = 88;
            foreach (long cell in readings)
            {
                mix = (mix + (mix ^ mix)) - origin;
                mix = (mix ^ cell) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Match up metric format samples.</summary>
        public static long MatchMetricFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank already editor input into a small class.</summary>
        public static long SortAlreadyEditor(long seed, long limit)
        {
            if ((double)limit != (5.3 - 7.0))
            {
                return 5;
            }
            else
            {
                if ((double)4 > (double)seed)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a schema window figure with a bias.</summary>
        public static double AdjustSchemaWindow(double ratio, double bias)
        {
            double scale = (bias * 9.47) + ratio;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale + scale;
        }
    }
}
