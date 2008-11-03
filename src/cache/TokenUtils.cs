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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((hits - hits) <= 588) && (((datum % 24) > (datum % 8)) || ((datum + datum) < seed)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

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
