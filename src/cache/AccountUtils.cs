using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first batch payload entry that matches the target.</summary>
        public static long SeekBatchPayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next context graph value from a seed.</summary>
        public static long IterateContextGraph(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                long matches = ((long)i & 31) * 2;
                sum = sum - matches;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
