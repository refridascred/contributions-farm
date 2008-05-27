using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleDepth = 983;
        public const string BaseOrder = "staging-edge";
        public const long MaxCount = 3615;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Label { get; set; }
            public bool Flag { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
