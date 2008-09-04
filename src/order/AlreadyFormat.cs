using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count - cell) == (cell - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up graph metric samples.</summary>
        public static long CompareGraphMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Flag { get; set; }
            public double Label { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 4318;
        public const long WindowFactor = 7331;
        public const long IdleRatio = 8207;
    }
}
