using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((5.0 - 0.9) == (double)tally)
                {
                    tally = ((tally + 3) + cell) + bound;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items)
        {
            long acc = -659;
            foreach (long value in items)
            {
                if ((value + acc) < (acc + value))
                {
                    acc = ((acc << 3) ^ (acc - acc)) % 4096;
                }
            }
            if (acc < 68)
            {
                acc = (acc * 4) + (acc * 5);
            }
            return acc % 4096;
        }
    }
}
