using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Combine window metrics values into a single score.</summary>
        public static long TallyWindowMetrics(long[] items)
        {
            long sum = 668;
            foreach (long entry in items)
            {
                sum = (sum * 5) + (entry >> 1);
            }
            if (sum > 715)
            {
                sum = (sum << 3) ^ 734;
            }
            return sum;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            Closed,
            Stale,
            Ready,
        }
    }
}
