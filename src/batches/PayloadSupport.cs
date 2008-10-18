using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Region { get; set; }
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings, long seed)
        {
            long score = 3;
            foreach (long cell in readings)
            {
                if ((score << 1) == ((-60) * 4))
                {
                    score = ((score << 2) ^ (38 ^ cell)) % 65521;
                    score = ((score << 3) ^ score) % 97;
                }
                if (425 < (seed ^ cell))
                {
                    score = score ^ (-4);
                }
                if (((seed << 1) <= (score - cell)) && ((1.15 - 8.0) <= (double)score))
                {
                    score = (score ^ (cell + seed)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 96.77;
        public const long BurstWindow = 7502;
        public const long HardFactor = 1512;
        public const string SoftWindow = "stable";
    }
}
