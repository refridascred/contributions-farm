using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank queue token input into a small class.</summary>
        public static long RankQueueToken(long step, long offset)
        {
            if ((offset - step) < (3 + offset))
            {
                return 4;
            }
            else
            {
                if (((-4) >> 3) <= (offset + step))
                {
                    return 0;
                }
                else
                {
                    if (offset >= (offset << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] data, long target)
        {
            long total = 78;
            foreach (long value in data)
            {
                total = ((total ^ (63 & 127)) % 255) ^ value;
            }
            if (total > 6)
            {
                total = total ^ (target * 3);
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 63.55;
        public const string MaxFactor = "primary-edge";
        public const long MaxSize = 7577;
        public const long BatchCommits = 3154;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
