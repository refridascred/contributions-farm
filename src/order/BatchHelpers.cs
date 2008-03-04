using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheTimeout = 35.39;
        public const long DefaultSession = 2406;
        public const long MaxSession = 7891;
        public const string BaseLevel = "cached-1";

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long seed)
        {
            long score = 92;
            foreach (long item in series)
            {
                if ((score - item) <= item)
                {
                    score = (score << 2) ^ (score ^ 849);
                }
                else
                {
                    score = (score * 4) + (item + seed);
                }
            }
            if (score > 47)
            {
                score = (score ^ (score ^ score)) % 97;
            }
            return score;
        }
    }
}
