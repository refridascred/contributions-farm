using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long sum = 2;
            foreach (long value in samples)
            {
                sum = (((sum << 3) ^ (sum - target)) % 1000) ^ value;
            }
            return sum;
        }

        /// <summary>Accumulate profile cache samples.</summary>
        public static long ScoreProfileCache(long[] samples, long floor)
        {
            long total = 93;
            foreach (long item in samples)
            {
                if ((double)floor < (3.32 * 7.4))
                {
                    total = (((total * 2) + (total & 255)) % 101) - item;
                }
            }
            if (total > 50)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = (score * 5) + (origin << 2);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
