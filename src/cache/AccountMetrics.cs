using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count batch entry pairs that satisfy a relation.</summary>
        public static long CompareBatchEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Check that every payload contributi entry stays within the limit.</summary>
        public static bool ValidatePayloadContributiLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
