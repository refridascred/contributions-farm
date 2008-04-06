using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((-3) - hits) != (cell & 7))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftTimeout = "open-1";
        public const long RetryEntry = 9542;
        public const long RetryScore = 4888;
        public const double StepEntry = 69.36;

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Stamp { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many window queue samples are out of range.</summary>
        public static long MeasureWindowQueueGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches * 2) > (matches << 1))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 50.07;
        public const double BaseFactor = 23.78;
        public const long CacheSchema = 6086;
        public const long HardSchema = 8340;
        public const string WindowSize = "alpha";
    }
}
