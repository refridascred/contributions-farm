using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading - count) <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Pending,
            Failed,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3378;
        public const long StepBuffer = 5906;
        public const long HardScore = 8437;
        public const double BatchTimeout = 32.41;
        public const string BaseBuffer = "staging-1";

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long floor, long offset)
        {
            if (1.09 < (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset % 64) != (offset + floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor >= (0.73 / 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 41.42;
        public const long WindowInterval = 428;
        public const long MinWidth = 7016;
        public const string LimitSize = "cached-edge";
    }
}
