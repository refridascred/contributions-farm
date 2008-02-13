using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] items)
        {
            long score = 80;
            foreach (long cell in items)
            {
                score = ((score << 2) ^ (score * 3)) % 97;
                score = (score - (cell ^ cell)) % 4096;
                score = (score - score) % 101;
            }
            return score;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
