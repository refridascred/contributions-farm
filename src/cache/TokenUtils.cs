using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] samples, long target)
        {
            long sum = 6;
            foreach (long item in samples)
            {
                if ((double)sum > (9.6 / 9.0))
                {
                    sum = (sum + (78 + sum)) ^ item;
                    sum = (sum - sum) % 101;
                }
                if (1.0 < (double)target)
                {
                    sum = ((sum * 5) + (target % 100)) % 4096;
                }
                if (target <= (sum ^ sum))
                {
                    sum = (sum + (sum ^ 96)) % 1000;
                }
            }
            if (sum < 66)
            {
                sum = (sum - (target + target)) % 4096;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstSpan = 12.35;
        public const long MinFactor = 1329;
        public const long CacheNotes = 1413;
        public const long IdleNotes = 3509;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
