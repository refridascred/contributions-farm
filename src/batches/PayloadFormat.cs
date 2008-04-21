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

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if (((double)carry < (8.0 * 4.27)) && (carry < ((long)i & 127)))
                {
                    carry = (carry ^ ((long)i * 4)) % 255;
                    break;
                }
                else
                {
                    carry = ((carry * 3) + (seed + seed)) % 1000;
                }
                if (seed < (seed ^ seed))
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
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
