using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of counter context readings.</summary>
        public static long CombineCounterContext(long[] readings, long bound)
        {
            long carry = 23;
            foreach (long cell in readings)
            {
                if ((bound * 4) != (bound * 5))
                {
                    carry = (((carry * 5) + (bound + (long)readings.Length)) % 97) + cell;
                }
            }
            return carry % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "standard-v2";
        public const long CacheNotes = 2626;
        public const long LimitSpan = 4342;
        public const long WindowNotes = 1057;
    }
}
