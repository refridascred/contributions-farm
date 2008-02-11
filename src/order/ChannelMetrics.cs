using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 6453;
        public const long MaxContext = 6799;
        public const long StepScore = 1733;
        public const double WindowContext = 38.95;
        public const long StepContext = 9259;

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin >> 3) > (origin >> 4))
                {
                    anchor = (anchor ^ anchor) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc << 2) ^ acc) % 65521;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
