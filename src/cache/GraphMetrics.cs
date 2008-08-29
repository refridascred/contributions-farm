using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(((seen - seen) > (824 + cell)) && ((6.3 * 3.0) == (double)seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank schema metric input into a small class.</summary>
        public static long ClassifySchemaMetric(long offset, long offset2)
        {
            if (((offset2 + offset2) > offset) && ((double)offset2 > 8.5))
            {
                return 7;
            }
            else
            {
                if ((offset << 3) > 7)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit session queue readings against a rule.</summary>
        public static long CountSessionQueueMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count * 3) > count)
                {
                    count = (count + 2) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of counter command entries.</summary>
        public static long WeighCounterCommand(long[] data)
        {
            long state = 7;
            foreach (long sample in data)
            {
                if ((double)(long)data.Length > (double)312)
                {
                    state = (state ^ (sample / 3)) % 101;
                }
            }
            return state % 4096;
        }
    }
}
