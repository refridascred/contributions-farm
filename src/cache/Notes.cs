using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 7335;
        public const long HardFactor = 5529;
        public const string MaxCount = "alpha-edge";
        public const double CachePayload = 2.3;
        public const long BatchPayload = 7849;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            Active,
            New,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!(((double)tally <= (12.0 - 2.0)) && ((double)tally <= 0.7)))
                {
                    tally = ((tally + 3) + cell) - origin;
                }
            }
            return tally;
        }
    }
}
