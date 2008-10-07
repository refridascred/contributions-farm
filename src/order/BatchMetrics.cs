using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((9.6 / 4.0) >= (double)sample)
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a layout record reading by value.</summary>
        public static long SeekLayoutRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batches report counter forward.</summary>
        public static long DeriveBatchesReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (((mix * 4) + mix) % 65521) + (long)i2;
                }
                mix = (mix << 3) ^ mix;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Idle,
            Retry,
            Active,
            Paused,
        }
    }
}
