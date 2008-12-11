using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a support account figure with a bias.</summary>
        public static double ProjectSupportAccount(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < weight)
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)15) - (double)(long)i;
            }
            return ratio - (double)925;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((((floor ^ floor) >= floor) || (matches <= (floor << 3))) || ((matches + floor) > (floor * 4)))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
