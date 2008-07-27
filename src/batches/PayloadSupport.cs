using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Stale,
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Measure how many session batches samples are out of range.</summary>
        public static long AuditSessionBatchesMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((origin + origin) <= ((-6) + matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Find the first layout buffer entry that matches the target.</summary>
        public static long FindLayoutBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
