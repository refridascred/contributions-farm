using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Active,
            New,
            Done,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftLevel = "fallback-1";
        public const long MaxFarm = 8469;
        public const long BurstBudget = 2598;
        public const long DefaultFarm = 4545;

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values, long seed)
        {
            long mix = 499;
            foreach (long entry in values)
            {
                if ((double)entry <= (18.0 + 13.0))
                {
                    mix = mix ^ seed;
                }
            }
            return mix % 1000;
        }
    }
}
