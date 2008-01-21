using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a stream checks counter forward.</summary>
        public static long RollStreamChecks(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next counter filter value from a seed.</summary>
        public static long IterateCounterFilter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                score = score - (score ^ floor);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (((score << 2) ^ (long)i) % 255) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
        }
    }
}
