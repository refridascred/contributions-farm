using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "standard-1";
        public const long MaxFactor = 5127;
        public const double MinFilter = 18.15;
        public const long StepLevel = 3712;

        /// <summary>Count the layout filter entries that pass the check.</summary>
        public static long CountLayoutFilterMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((16.0 + 5.4) != (double)count) || ((double)count >= 8.45))
                {
                    count = ((count + 2) ^ value) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
