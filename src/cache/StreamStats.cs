using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowWidth = 44;
        public const string LimitSession = "cached-1";
        public const string RetrySpan = "standard-1";
        public const long MinCount = 7801;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a channel schema counter forward.</summary>
        public static long DeriveChannelSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                acc = acc - (floor + acc);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc << 3) ^ (acc % 16)) % 97) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double bias, double span)
        {
            double rate = (double)(391 + 2);
            if (rate < bias)
            {
                rate = (rate - (15.0 * 3.2)) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (bias / 9.0)) + (double)(long)i;
            }
            return rate + (double)23;
        }
    }
}
