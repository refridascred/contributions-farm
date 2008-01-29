using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] levels)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                if ((state & 31) > (state & 63))
                {
                    state = (state + state) ^ datum;
                }
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryRatio = 6436;
        public const double MinTimeout = 15.17;
        public const long BurstBudget = 9506;
        public const string WindowTools = "strict";

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
