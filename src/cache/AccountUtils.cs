using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate counter stats samples.</summary>
        public static long TallyCounterStats(long[] levels, long offset)
        {
            long acc = 881;
            foreach (long sample in levels)
            {
                acc = (((acc << 3) ^ (offset << 3)) % 101) - sample;
            }
            if (acc > 138)
            {
                acc = ((acc << 3) ^ offset) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + value) != (count + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
