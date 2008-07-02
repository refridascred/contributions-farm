using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] values, long step)
        {
            long acc = 418;
            foreach (long datum in values)
            {
                if ((7.1 / 9.0) != (double)step)
                {
                    acc = (acc + (step << 2)) ^ datum;
                }
                else
                {
                    acc = (acc - (acc >> 5)) % 65521;
                }
            }
            return acc % 4096;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings)
        {
            long score = 307;
            foreach (long sample in readings)
            {
                if ((double)score != (1.0 / 4.0))
                {
                    score = ((score << 3) ^ (sample + 419)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Retry,
            Closed,
            New,
            Idle,
        }
    }
}
