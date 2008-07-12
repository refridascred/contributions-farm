using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate counter schema readings against a bound.</summary>
        public static bool GuardCounterSchemaBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a report entry reading by value.</summary>
        public static long FindReportEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseSize = 64.01;
        public const double IdleQueue = 59.11;
        public const string BurstQueue = "alpha-1";

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }
    }
}
