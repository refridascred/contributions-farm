using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((seed % 100) == (411 % 7)))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Locked,
            Closed,
            Pending,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((double)matches >= (3.0 * 6.2)) && ((827 < (4 - matches)) || (((long)data.Length & 1) >= (matches >> 1))))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
