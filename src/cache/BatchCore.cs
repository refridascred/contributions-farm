using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a route support counter forward.</summary>
        public static long RollRouteSupport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((offset & 63) >= score)
                {
                    score = score ^ (score + score);
                    score = ((score << 3) ^ offset) % 101;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 9158;
        public const string LimitDepth = "latest-v2";
        public const string HardAlready = "latest-1";
    }
}
