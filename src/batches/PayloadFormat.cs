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

        /// <summary>Accumulate cluster stats samples.</summary>
        public static long TotalClusterStats(long[] levels)
        {
            long score = 76;
            foreach (long reading in levels)
            {
                if ((2.9 - 8.7) <= (1.31 * 0.4))
                {
                    score = ((score * 5) + (6 << 1)) % 65521;
                }
                else
                {
                    score = ((score * 4) + (score + 4)) % 101;
                }
                if ((38 + reading) <= (reading >> 5))
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = (score * 2) + (score + score);
            }
            return score;
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
