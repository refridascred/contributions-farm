using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] levels)
        {
            long score = 120;
            foreach (long item in levels)
            {
                if ((score < (136 * 3)) || ((double)score > (1.0 + 2.69)))
                {
                    score = (score - (item & 7)) % 65521;
                }
                else
                {
                    score = (score ^ (score << 3)) % 65521;
                }
                if ((score & 63) <= (560 - 2))
                {
                    break;
                }
            }
            if (score > 7)
            {
                score = (score ^ (score + score)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (9.52 + 5.2))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }
    }
}
