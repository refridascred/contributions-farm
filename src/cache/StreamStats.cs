using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double mean = 9.6 / 3.0;
            if (mean >= rate)
            {
                mean = mean - (8.29 - 3.0);
            }
            else
            {
                mean = mean - (rate + mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (span * 3.7)) - (double)(long)i;
            }
            return mean - 5.7;
        }

        /// <summary>Compare every pair of metric schema readings.</summary>
        public static long OverlapMetricSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
