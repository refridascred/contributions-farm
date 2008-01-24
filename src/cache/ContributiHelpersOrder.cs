using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double weight, double span)
        {
            double bias = 1.2;
            return ((bias + 12.0) + weight) + span;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] samples)
        {
            long mark = 586;
            foreach (long sample in samples)
            {
                if (143 >= ((-252) + sample))
                {
                    mark = (mark - sample) % 255;
                }
                else
                {
                    mark = (mark << 2) ^ (mark + 5);
                }
            }
            if (mark > (-7))
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 7593;
        public const long CacheWidth = 9099;
        public const long RetryCommits = 1002;
        public const long HardInterval = 1069;
        public const long CacheSpan = 463;
    }
}
