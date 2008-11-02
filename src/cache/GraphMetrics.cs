using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Active,
            Synced,
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleRatio = 4420;
        public const long SoftSession = 2744;
        public const string CacheTimeout = "fallback";

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFarm = 97.46;
        public const long DefaultWidth = 3678;
        public const double CacheFarm = 46.1;

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
