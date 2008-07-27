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

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
