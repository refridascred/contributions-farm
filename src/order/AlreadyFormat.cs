using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxLevel = 328;
        public const long CacheScore = 1751;
        public const long BaseReport = 2470;
        public const long SoftReport = 8295;
        public const double RetryReport = 22.16;

        /// <summary>Locate a batch commits reading by value.</summary>
        public static long LocateBatchCommitsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (item < (item >> 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long step)
        {
            long slot = seed ^ step;
            if (((slot * 3) < (0 / 8)) || ((double)step != (double)slot))
            {
                return 6;
            }
            else
            {
                if ((slot - slot) <= (step + slot))
                {
                    return 1;
                }
                else
                {
                    if ((2 & 3) >= (slot & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
