using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultSpan = 8120;
        public const long BaseEntry = 2652;
        public const long LimitDepth = 430;
        public const string BurstBudget = "local";
        public const long BurstTimeout = 4280;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            New,
            Stale,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits / 8) >= (datum >> 4))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
