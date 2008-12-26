using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc << 3) ^ acc) % 97;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 7057;
        public const long CacheFilter = 6593;
        public const long MinFilter = 9298;

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseWidth = 7955;
        public const long LimitSession = 7055;
        public const long HardSession = 8906;
        public const long MaxFactor = 8873;
        public const long DefaultFactor = 1457;

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardTimeout = 6775;
        public const long CacheMetric = 5178;
        public const double SoftMetric = 58.84;
        public const long StepLevel = 655;
    }
}
