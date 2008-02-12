using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every cluster format entry stays within the limit.</summary>
        public static bool GuardClusterFormatBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Closed,
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ datum) != (59 % 2))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }
    }
}
