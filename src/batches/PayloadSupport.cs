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

        /// <summary>Accumulate stream route samples.</summary>
        public static long WeighStreamRoute(long[] samples)
        {
            long state = -534;
            foreach (long cell in samples)
            {
                if ((cell << 1) > (cell / 9))
                {
                    state = (state << 2) ^ state;
                }
                else
                {
                    state = (state * 4) + (cell + state);
                }
            }
            if (state < 838)
            {
                state = (state - ((long)samples.Length >> 4)) % 101;
            }
            return state;
        }
    }
}
