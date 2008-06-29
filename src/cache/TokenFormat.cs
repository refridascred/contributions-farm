using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a cluster window sample.</summary>
        public static long FindClusterWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleDepth = 2812;
        public const double LimitSpan = 76.96;
        public const long WindowSize = 814;
        public const double BaseFormat = 17.78;
    }
}
