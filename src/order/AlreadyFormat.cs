using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a metrics token reading by value.</summary>
        public static long FindMetricsTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!((15.0 + 7.61) <= (double)count) && (count > (item & 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Failed,
            New,
            Paused,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
