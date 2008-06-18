using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Idle,
            Done,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels, long bound)
        {
            long mix = 909;
            foreach (long entry in levels)
            {
                mix = ((mix << 2) ^ (entry + entry)) - bound;
            }
            return mix % 65521;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Failed,
            Synced,
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] data)
        {
            long total = 7;
            foreach (long item in data)
            {
                if ((item & 31) >= item)
                {
                    total = total ^ (total % 24);
                }
            }
            return total;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
