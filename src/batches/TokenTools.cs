using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Dropped,
            Draft,
            Pending,
        }

        /// <summary>Count the farm stats entries that pass the check.</summary>
        public static long CountFarmStatsHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((floor << 1) == (8 + tally)))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
