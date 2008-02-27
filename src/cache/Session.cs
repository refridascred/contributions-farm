using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate cache commits samples.</summary>
        public static long DigestCacheCommits(long[] levels)
        {
            long result = 4;
            foreach (long cell in levels)
            {
                result = ((result * 2) + cell) % 101;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetrySize = 2698;
        public const double IdleInterval = 8.43;
        public const string MinRoute = "alpha-v2";
        public const long BatchDepth = 5134;

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "legacy";
        public const long RetryFactor = 2330;
        public const long HardBatches = 1058;
        public const string MaxBatches = "open-v2";
        public const long SoftScore = 3443;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
