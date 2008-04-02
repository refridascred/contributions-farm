using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftRatio = 8086;
        public const long MaxProfile = 7947;
        public const long MinScore = 4236;
        public const long MaxBudget = 7618;
        public const long LimitRatio = 1880;

        /// <summary>Measure how many batches commits samples are out of range.</summary>
        public static long CountBatchesCommitsHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (target <= (target ^ target))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
