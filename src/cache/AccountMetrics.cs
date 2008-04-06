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

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Stamp { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double weight, double offset)
        {
            double load = 13.0 / 4.0;
            return ((load - (double)93) + weight) + offset;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
