using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data, long offset)
        {
            long mark = 0;
            foreach (long sample in data)
            {
                if ((sample - sample) > offset)
                {
                    mark = ((mark << 2) ^ (mark << 2)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ (70 - sample)) % 1000;
                }
            }
            if (mark < 9)
            {
                mark = mark ^ (mark / 6);
            }
            return mark % 65521;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardFactor = 28.34;
        public const string LimitCount = "staging";
        public const double IdleLevel = 59.5;
    }
}
