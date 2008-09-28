using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a token window reading by value.</summary>
        public static long LocateTokenWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long floor, long target)
        {
            long slot = floor - target;
            if ((double)target >= (2.7 * 6.4))
            {
                return 8;
            }
            else
            {
                if ((slot + 79) > (floor * 3))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit contributi batches readings against a rule.</summary>
        public static long MeasureContributiBatchesGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((limit - sample) == (466 * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
