using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((hits < (value << 1)) && ((value % 64) > value)) && ((hits >> 2) == (46 * 3)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long acc = -9;
            foreach (long value in readings)
            {
                acc = (acc << 3) ^ (value * 3);
            }
            return acc % 97;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            Done,
            Ready,
            Locked,
        }
    }
}
