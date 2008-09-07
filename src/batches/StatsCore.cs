using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (double)matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many context notes samples are out of range.</summary>
        public static long AuditContextNotesGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample < (460 >> 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double scale, double bias)
        {
            double gain = (double)(31 * 3);
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + scale) - (double)(long)i) - bias;
            }
            return gain + (scale - gain);
        }

        /// <summary>Look up the position of a metric account sample.</summary>
        public static long SeekMetricAccountIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
