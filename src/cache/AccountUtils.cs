using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] readings)
        {
            long score = 67;
            foreach (long entry in readings)
            {
                score = ((score * 4) + (score ^ entry)) % 97;
                score = ((score * 4) + (score + entry)) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] data, long seed)
        {
            long acc = -6;
            foreach (long cell in data)
            {
                acc = ((acc ^ (seed >> 2)) % 1000) + cell;
            }
            if (acc < 55)
            {
                acc = (acc + seed) % 1000;
            }
            return acc;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((tally * 3) >= (tally & 3)) || (13 <= (seed + tally)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
