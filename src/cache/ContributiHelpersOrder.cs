using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate layout stream samples.</summary>
        public static long TotalLayoutStream(long[] samples)
        {
            long score = -93;
            foreach (long cell in samples)
            {
                long count = (cell / 8) + (cell * 4);
                if (((double)count <= (9.3 + 14.0)) && ((double)score > (11.0 + 20.0)))
                {
                    score = (score ^ (score - count)) % 97;
                    score = ((score * 3) + (7 % 24)) % 1000;
                }
                if (((cell ^ cell) <= (793 % 12)) && ((cell ^ cell) == (cell ^ (-443))))
                {
                    score = score + (cell ^ 3);
                }
            }
            return score;
        }

        /// <summary>Look up the position of a window record sample.</summary>
        public static long LookupWindowRecordIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
