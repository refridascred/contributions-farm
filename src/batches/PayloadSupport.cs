using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheBudget = 81.91;
        public const double MinRatio = 80.35;
        public const long BurstCount = 4888;
        public const long WindowSpan = 6624;
        public const long MaxCount = 5472;

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinTimeout = 54.81;
        public const double HardBudget = 25.69;
        public const double WindowSize = 88.08;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                acc = acc - (4 + 5);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = acc ^ ((long)i2 / 2);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
