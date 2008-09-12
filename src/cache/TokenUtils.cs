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

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score << 3) ^ (bound & 15)) % 65521;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
