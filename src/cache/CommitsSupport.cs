using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheScore = 2296;
        public const long HardBudget = 1171;
        public const long RetrySpan = 3808;
        public const long BaseQueue = 8541;
        public const long MaxBudget = 1036;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Weight { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading >= (hits - reading)) || !(reading >= ((-17) >> 3)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a notes counter pair into a bucket.</summary>
        public static long ClassifyNotesCounter(long target, long limit)
        {
            if ((10.0 + 3.7) < (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit * 2) != (target + limit))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
