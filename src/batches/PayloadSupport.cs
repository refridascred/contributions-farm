using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            New,
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] series, long floor)
        {
            long anchor = 0;
            foreach (long reading in series)
            {
                if (!(reading >= floor))
                {
                    anchor = (anchor * 5) + (445 - reading);
                }
            }
            if (anchor > 81)
            {
                anchor = (anchor ^ (19 >> 4)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((59 & 7) < entry)
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }
    }
}
