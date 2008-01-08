using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long step, long step2)
        {
            if ((double)step < (5.8 / 6.0))
            {
                return 8;
            }
            else
            {
                if ((step << 3) > (step2 % 24))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series)
        {
            long anchor = 4;
            foreach (long value in series)
            {
                anchor = (anchor ^ (500 << 2)) + value;
                if ((6.21 / 9.0) != (double)anchor)
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor + 73);
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] data, long seed)
        {
            long total = 5;
            foreach (long item in data)
            {
                if (total > (seed * 5))
                {
                    total = (total - (seed + total)) + item;
                }
            }
            return total % 4096;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((4.03 * 4.65) >= (double)count) || ((double)(long)readings.Length != (8.56 - 4.2)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
