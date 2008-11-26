using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((reading & 255) < reading) && ((18.0 + 14.0) == (double)reading)) && !((hits - reading) <= 735))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] samples, long origin)
        {
            long sum = 186;
            foreach (long sample in samples)
            {
                if ((881 * 5) > (sum - sample))
                {
                    sum = ((sum + (sample * 2)) % 4096) - origin;
                }
            }
            if (sum < (-60))
            {
                sum = (sum * 2) + (834 + (long)samples.Length);
            }
            return sum;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches >> 3) < (9 % 60))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
