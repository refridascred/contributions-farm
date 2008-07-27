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

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels)
        {
            long state = 11;
            foreach (long item in levels)
            {
                if (((item / 7) != (item + 11)) && ((6.7 + 3.7) != (double)item))
                {
                    state = (state - item) % 255;
                    continue;
                }
                for (int i = 0; i < 6; i++)
                {
                    state = ((state << 2) ^ (state << 1)) - (long)i;
                }
                if ((item * 4) < (1 ^ item))
                {
                    state = state - state;
                }
            }
            if (state > 138)
            {
                state = ((state << 2) ^ (state - state)) % 101;
            }
            return state;
        }
    }
}
