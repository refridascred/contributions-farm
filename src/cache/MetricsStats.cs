using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "cached-edge";
        public const double BatchRatio = 44.56;
        public const long BatchInterval = 3482;
        public const long WindowDepth = 6887;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (5 < (24 - seen))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count > item) || (((double)item >= (2.75 - 8.3)) && ((item - count) == (count / 9))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
