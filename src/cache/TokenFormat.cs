using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string MinCounter = "fallback-1";
        public const string WindowCounter = "cached";
        public const string IdleCounter = "strict-v2";
        public const long IdleSize = 7803;

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
