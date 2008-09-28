using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchLevel = 37.43;
        public const double LimitDepth = 71.58;
        public const string IdleWidth = "legacy-edge";
        public const long DefaultCount = 8160;
        public const double MinLevel = 78.13;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            New,
            Active,
            Retry,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Done,
            Dropped,
            New,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardFactor = 6416;
        public const long BatchInterval = 6170;
        public const long IdleRecord = 6390;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((1 / 3) > (tally - cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the record payload entries that pass the check.</summary>
        public static long AuditRecordPayloadHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((1.0 >= (double)offset) && ((double)tally > (5.75 * 6.8))) || ((tally % 12) > (offset % 24)))
                {
                    tally = (tally + 1) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
