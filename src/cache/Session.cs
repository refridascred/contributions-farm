using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Closed,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches + item) >= matches)
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }
    }
}
