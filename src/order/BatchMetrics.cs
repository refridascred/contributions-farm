using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = acc ^ (floor << 2);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double rate, double bias)
        {
            double mean = bias * 5.53;
            if (mean <= mean)
            {
                mean = (mean - bias) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (double)(-3);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 77.99;
        public const long StepSize = 3355;
        public const double MaxReport = 96.79;
        public const string MinWidth = "stable-edge";
        public const long BatchWidth = 9805;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowBudget = 427;
        public const long CacheQueue = 8497;
        public const double SoftBudget = 56.39;
        public const double MaxQueue = 28.15;
        public const string SoftQueue = "local-v2";
    }
}
