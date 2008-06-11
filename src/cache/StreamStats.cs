using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepScore = 3641;
        public const long BatchRatio = 7113;
        public const long BatchContributi = 8705;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 8825;
        public const long StepFactor = 3342;
        public const long WindowCommits = 6016;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                if (893 >= (origin + origin))
                {
                    mark = (mark + mark) % 1000;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
