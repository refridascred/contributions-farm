using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Idle,
            Done,
            Dropped,
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
