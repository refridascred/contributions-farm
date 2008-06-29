using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of checks farm entries.</summary>
        public static long CombineChecksFarm(long[] values, long bound)
        {
            long acc = 7;
            foreach (long cell in values)
            {
                if (acc >= (cell / 3))
                {
                    acc = (acc ^ cell) % 65521;
                    acc = ((acc << 2) ^ (acc / 4)) % 4096;
                }
                acc = ((acc << 2) ^ acc) % 97;
                if ((bound / 5) >= (bound - 70))
                {
                    acc = (acc << 3) ^ acc;
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

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
