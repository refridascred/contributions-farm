using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 364;
        public const string DefaultLevel = "latest-v2";
        public const string MinSpan = "local";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryCount = 9436;
        public const long LimitInterval = 2241;
        public const long HardContributi = 8168;
    }
}
