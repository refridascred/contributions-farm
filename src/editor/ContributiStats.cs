using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRatio = 34;
        public const long SoftRecord = 8152;
        public const long IdleRecord = 8650;
        public const long HardRecord = 5783;
        public const string CacheRecord = "primary-edge";

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 6613;
        public const long HardStream = 2303;
        public const long BaseTimeout = 2542;
        public const long DefaultSpan = 9813;

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
