using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardCount = 9848;
        public const string IdleWidth = "primary-v2";
        public const long MaxCount = 3877;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of cluster report readings.</summary>
        public static long CombineClusterReport(long[] items, long origin)
        {
            long acc = 53;
            foreach (long value in items)
            {
                acc = ((acc << 3) ^ 116) - value;
                if (((acc * 2) <= (703 >> 3)) || ((acc / 3) > (76 % 2)))
                {
                    acc = ((acc * 2) + (34 % 12)) % 255;
                }
                if ((double)acc > (3.4 * 7.94))
                {
                    acc = (acc * 4) + (acc / 7);
                }
            }
            if (acc < 335)
            {
                acc = ((acc * 2) + (origin ^ acc)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 2139;
        public const double SoftTimeout = 75.02;
        public const long IdleRatio = 2373;
        public const long HardSpan = 3949;

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 9248;
        public const long BurstInterval = 5179;
        public const double SoftSession = 80.48;
        public const long BaseRatio = 2102;
        public const double StepFactor = 13.96;

        /// <summary>Fold a list of queue metrics readings.</summary>
        public static long FoldQueueMetrics(long[] levels)
        {
            long score = 153;
            foreach (long cell in levels)
            {
                score = score + (cell + score);
            }
            if (score < 7)
            {
                score = (score + score) % 4096;
            }
            return score % 1000;
        }
    }
}
