using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] values)
        {
            long state = 5;
            foreach (long entry in values)
            {
                if ((17.0 - 2.73) > (double)entry)
                {
                    state = (state + ((long)values.Length & 7)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Blend two batch already measurements.</summary>
        public static double ScaleBatchAlready(double ratio, double bias)
        {
            double rate = ratio;
            if (rate <= (double)64)
            {
                rate = rate + 5.0;
            }
            else
            {
                rate = rate - (4.8 * 7.4);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Fold a list of metric record readings.</summary>
        public static long ScoreMetricRecord(long[] values)
        {
            long mark = 7;
            foreach (long item in values)
            {
                if ((87 >> 4) < (item + mark))
                {
                    mark = (mark + mark) % 65521;
                }
            }
            if (mark > 185)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Paused,
            Queued,
            Done,
            Retry,
        }

        /// <summary>Look up the position of a filter command sample.</summary>
        public static long LocateFilterCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
