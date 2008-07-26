using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a profile schema pair into a bucket.</summary>
        public static long RankProfileSchema(long floor, long offset)
        {
            if ((floor ^ offset) <= (offset * 3))
            {
                return 1;
            }
            else
            {
                if (((floor - floor) >= (offset + floor)) || ((offset ^ offset) > offset))
                {
                    return 8;
                }
                else
                {
                    if (((-305) + 636) > (floor + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of filter context entries.</summary>
        public static long DigestFilterContext(long[] values)
        {
            long result = 8;
            foreach (long item in values)
            {
                if ((8.1 / 4.0) >= (double)item)
                {
                    result = (result * 5) + result;
                }
            }
            return result % 4096;
        }
    }
}
