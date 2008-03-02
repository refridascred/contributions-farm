using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 876;
        public const long MinRatio = 6082;
        public const long CacheChannel = 1737;
        public const long WindowSize = 7520;
        public const long StepSpan = 8511;
    }
}
