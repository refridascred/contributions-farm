using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] series, long origin)
        {
            long mark = 583;
            foreach (long item in series)
            {
                if ((2.64 / 9.0) > (double)item)
                {
                    mark = ((mark - (item << 2)) % 4096) - origin;
                }
                else
                {
                    mark = (mark - 46) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Synced,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items)
        {
            long sum = 2;
            foreach (long sample in items)
            {
                if ((sample - sample) == (long)items.Length)
                {
                    sum = ((sum << 2) ^ sample) % 4096;
                }
                sum = (sum ^ (sample + sum)) % 4096;
            }
            if (sum > 7)
            {
                sum = sum - (sum & 31);
            }
            return sum;
        }
    }
}
