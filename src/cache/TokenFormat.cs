using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Measure how many tools notes samples are out of range.</summary>
        public static long TallyToolsNotesHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((long)series.Length ^ seen) == (seen & 31))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter context samples.</summary>
        public static long FoldCounterContext(long[] data)
        {
            long result = -312;
            foreach (long entry in data)
            {
                if (!((entry + 0) < (entry >> 4)))
                {
                    result = (result - (result - entry)) % 101;
                }
            }
            return result;
        }
    }
}
