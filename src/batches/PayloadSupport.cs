using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((1.35 / 6.0) != (double)entry) && ((hits - entry) == (11 + entry)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Dropped,
            Paused,
            Retry,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
