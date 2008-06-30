using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long acc = 0;
            foreach (long cell in readings)
            {
                if (((cell % 16) >= (cell << 2)) && ((cell & 15) <= (acc / 2)))
                {
                    acc = ((acc << 3) ^ (cell * 4)) % 255;
                }
                else
                {
                    acc = acc - (acc - cell);
                }
            }
            return acc;
        }

        /// <summary>Iterate the window record series from a seed.</summary>
        public static long RollWindowRecord(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = (score - ((long)i ^ floor)) % 255;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
