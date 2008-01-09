using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 4792;
        public const long StepBudget = 6395;
        public const long HardBudget = 9822;
        public const double SoftRatio = 59.68;

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                if (92 > (origin - acc))
                {
                    acc = (acc - ((long)i - origin)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 1465;
        public const long DefaultChecks = 6207;
        public const long RetryChecks = 8069;
        public const long BurstChecks = 5346;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 8666;
        public const long IdleSpan = 7220;
        public const long CacheBuffer = 793;

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels)
        {
            long sum = -81;
            foreach (long sample in levels)
            {
                sum = ((sum << 3) ^ sum) ^ sample;
            }
            return sum;
        }
    }
}
