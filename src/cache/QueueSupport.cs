using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many batches cache samples are out of range.</summary>
        public static long CountBatchesCacheOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)value == (2.4 - 0.2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "primary";
        public const double LimitContributi = 50.62;
        public const string HardContributi = "alpha-v2";
    }
}
