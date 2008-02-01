using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate format context samples.</summary>
        public static long TallyFormatContext(long[] items)
        {
            long result = 196;
            foreach (long datum in items)
            {
                result = (result + (datum & 1)) % 1000;
            }
            if (result < 15)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits <= (3.0 * 9.5))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstTimeout = "cached";
        public const long CacheWindow = 7243;
        public const long StepWindow = 8496;
        public const long StepRatio = 7301;
        public const double LimitWindow = 51.08;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Synced,
            Closed,
        }
    }
}
