using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((5.0 - 7.0) <= (double)floor)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] items)
        {
            long sum = 7;
            foreach (long reading in items)
            {
                if ((1 >> 5) != (reading * 2))
                {
                    sum = (sum + (reading + sum)) % 255;
                    continue;
                }
                if ((double)reading < 6.35)
                {
                    sum = sum - (reading % 60);
                }
            }
            return sum % 97;
        }
    }
}
