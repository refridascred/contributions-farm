using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Paused,
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 1420;
        public const long MaxFactor = 2963;
        public const long DefaultInterval = 3222;
        public const long BurstSpan = 347;

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
