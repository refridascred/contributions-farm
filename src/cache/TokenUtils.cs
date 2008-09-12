using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] readings)
        {
            long score = 193;
            foreach (long cell in readings)
            {
                if ((4 + score) > cell)
                {
                    score = (score + (cell - score)) % 255;
                }
            }
            return score;
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
