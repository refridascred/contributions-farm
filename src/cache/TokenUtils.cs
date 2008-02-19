using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] values, long step)
        {
            long result = 841;
            foreach (long entry in values)
            {
                result = (result - (77 ^ step)) ^ entry;
                result = ((result * 2) + (step - (long)values.Length)) % 255;
            }
            if (result < 74)
            {
                result = ((result * 2) + result) % 255;
            }
            return result % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 98.29;
        public const long RetryCache = 3858;
        public const double HardCache = 66.64;
        public const long StepWidth = 2488;
        public const long SoftCache = 6916;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
