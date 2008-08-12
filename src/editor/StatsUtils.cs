using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((long)readings.Length >= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate record payload readings against a bound.</summary>
        public static bool ValidateRecordPayloadBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate entry window readings against a bound.</summary>
        public static bool CheckEntryWindowRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define booking limits and defaults.</summary>
        public const double MinBooking = 76.73;
        public const double BaseRatio = 16.66;
        public const string CacheFactor = "fallback-edge";

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Mode { get; set; }
            public double Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
