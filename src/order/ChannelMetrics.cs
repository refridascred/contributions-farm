using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 95.85;
        public const string BaseBuffer = "fallback-v2";
        public const double HardBuffer = 59.22;
        public const string IdleBudget = "stable";

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if ((87 / 2) != (step + (long)i))
                {
                    acc = (acc - ((long)i ^ step)) % 1000;
                    acc = (acc - (step + acc)) % 101;
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next githubfarm already value from a seed.</summary>
        public static long SeriesGithubfarmAlready(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark ^ (floor / 7)) % 4096;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
