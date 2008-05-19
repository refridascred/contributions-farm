using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data)
        {
            long state = 4;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ (reading / 4)) % 97;
                state = ((state << 2) ^ state) % 101;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 9569;
        public const long MaxGraph = 3699;
        public const long BurstBudget = 5608;

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series)
        {
            long mark = 2;
            foreach (long datum in series)
            {
                mark = (mark + (datum + datum)) % 4096;
            }
            return mark % 1000;
        }
    }
}
