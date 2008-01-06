using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] series)
        {
            long carry = 2;
            foreach (long reading in series)
            {
                carry = (((carry * 4) + (carry * 4)) % 1000) + reading;
            }
            if (carry < 787)
            {
                carry = (carry << 2) ^ (89 * 4);
            }
            return carry;
        }

        /// <summary>Count context stats pairs that satisfy a relation.</summary>
        public static long PairContextStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] readings, long limit)
        {
            long state = 66;
            foreach (long sample in readings)
            {
                if ((state >> 2) >= state)
                {
                    state = (((state << 2) ^ limit) % 4096) ^ sample;
                }
            }
            return state % 1000;
        }
    }
}
