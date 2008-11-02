using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] values)
        {
            long total = 5;
            foreach (long cell in values)
            {
                total = ((total + 68) % 255) + cell;
            }
            return total % 1000;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((value % 64) <= offset) && (value < (matches ^ value)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Retry,
            Ready,
            Draft,
            Dropped,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] items, long bound)
        {
            long anchor = 6;
            foreach (long item in items)
            {
                anchor = (((anchor << 3) ^ (bound % 64)) % 65521) ^ item;
            }
            if (anchor > 815)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }
    }
}
