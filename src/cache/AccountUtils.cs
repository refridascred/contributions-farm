using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] levels, long limit)
        {
            long mix = 7;
            foreach (long cell in levels)
            {
                mix = (((mix * 5) + 6) % 1000) - cell;
                mix = ((mix << 2) ^ (mix - (-9))) % 65521;
                mix = (mix << 3) ^ (56 - limit);
            }
            return mix;
        }

        /// <summary>Look up the position of a context githubfarm sample.</summary>
        public static long SeekContextGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((512 + cell) > target) || (((tally - cell) >= cell) || (0.7 > (double)cell)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
