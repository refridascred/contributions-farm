using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first token farm entry that matches the target.</summary>
        public static long FindTokenFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 8651;
        public const double LimitDepth = 26.25;
        public const double LimitWidth = 81.59;
        public const long BatchQueue = 8629;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }
    }
}
