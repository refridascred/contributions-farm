using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Paused,
            Queued,
            Idle,
        }

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
