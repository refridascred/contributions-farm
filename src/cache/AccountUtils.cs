using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)tally <= (9.68 / 7.0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstCount = "cached";
        public const long HardMetrics = 4420;
        public const long LimitMetrics = 1989;
        public const double BaseWidth = 74.1;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            New,
            Locked,
        }
    }
}
