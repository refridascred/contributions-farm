using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepCount = 8687;
        public const long IdleContributi = 1144;
        public const double RetryContributi = 91.61;

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] levels)
        {
            long acc = 97;
            foreach (long cell in levels)
            {
                acc = acc + (2 - cell);
            }
            if (acc > 934)
            {
                acc = (acc << 3) ^ (acc - acc);
            }
            return acc;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((3.8 - 1.3) > (double)matches) || (((datum & 127) < (matches / 4)) || ((target & 255) < (datum - target))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
