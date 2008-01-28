using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit metrics cache readings against a rule.</summary>
        public static long MeasureMetricsCacheMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (bound < (bound + bound))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long offset, long bound)
        {
            if ((16.0 - 7.98) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((offset >> 1) == (bound / 6))
                {
                    return 3;
                }
                else
                {
                    if (21 < (bound % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(17.0 >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first format metrics entry that matches the target.</summary>
        public static long FindFormatMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
