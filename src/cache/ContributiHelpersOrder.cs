using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "legacy";
        public const long BatchGraph = 5645;
        public const long MinLevel = 2238;
        public const long MaxInterval = 5284;

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 8639;
        public const long CacheAccount = 929;
        public const long HardAccount = 3619;
        public const string BurstAccount = "local-edge";

        /// <summary>Count batches tools pairs that satisfy a relation.</summary>
        public static long PairBatchesToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
