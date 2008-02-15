using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a filter route sample.</summary>
        public static long FindFilterRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 8443;
        public const long LimitSize = 3352;
        public const long MinLevel = 5493;
        public const long BatchFactor = 688;

        /// <summary>Count the notes tools entries that pass the check.</summary>
        public static long MeasureNotesToolsHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > (reading - reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
