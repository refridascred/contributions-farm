using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell & 3) >= (tally % 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the channel cache series from a seed.</summary>
        public static long RollChannelCache(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = (state - (state % 5)) % 1000;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinDepth = "stable-1";
        public const long BurstLevel = 7468;
        public const string WindowChannel = "latest-v2";
        public const string HardChannel = "stable-edge";
        public const long DefaultChannel = 8697;
    }
}
