using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit batch graph readings against a rule.</summary>
        public static long MeasureBatchGraphOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (6.55 + 4.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowSpan = 9605;
        public const long BatchRatio = 114;
        public const long CacheScore = 2060;
        public const long MaxScore = 4479;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long seed, long step)
        {
            long gap = seed - step;
            if ((seed + seed) == (step - gap))
            {
                return 4;
            }
            else
            {
                if ((seed + gap) > (14 + seed))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
