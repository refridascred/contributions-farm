using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 8268;
        public const long IdleFarm = 5945;
        public const string BurstFarm = "fallback";

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
