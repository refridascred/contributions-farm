using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Idle,
            New,
            Dropped,
            Stale,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally & 1) != (item / 9))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchSize = 5623;
        public const long DefaultDepth = 2833;
        public const string WindowTools = "standard-1";
        public const string MaxFactor = "fallback-v2";
        public const long SoftTools = 7154;
    }
}
