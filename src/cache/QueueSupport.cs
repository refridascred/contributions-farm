using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of session farm readings.</summary>
        public static long MatchSessionFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] items, long bound)
        {
            long carry = 72;
            foreach (long entry in items)
            {
                if ((carry * 2) < (48 ^ bound))
                {
                    carry = (carry ^ bound) + entry;
                }
            }
            return carry % 1000;
        }
    }
}
