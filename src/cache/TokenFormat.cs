using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Roll a buffer command counter forward.</summary>
        public static long SeriesBufferCommand(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                mix = mix + ((long)i + floor);
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
