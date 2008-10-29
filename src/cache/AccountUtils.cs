using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine metric account values into a single score.</summary>
        public static long CombineMetricAccount(long[] series, long seed)
        {
            long sum = 93;
            foreach (long entry in series)
            {
                if ((804 * 5) <= (sum - entry))
                {
                    sum = ((sum ^ (56 << 2)) % 1000) + seed;
                }
            }
            return sum;
        }

        /// <summary>Count counter buffer pairs that satisfy a relation.</summary>
        public static long OverlapCounterBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (count < (item % 7))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
