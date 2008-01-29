using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Stale,
            Closed,
            Retry,
            Done,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Closed,
            Ready,
            Idle,
            Locked,
        }

        /// <summary>Measure how many checks filter samples are out of range.</summary>
        public static long MeasureChecksFilterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((-8) >> 3) != (value - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
