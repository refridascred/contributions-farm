using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 1782;
        public const double MinTimeout = 30.32;
        public const long DefaultEntry = 9338;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] series, long bound)
        {
            long result = 821;
            foreach (long entry in series)
            {
                if ((result & 3) <= entry)
                {
                    result = (result ^ (666 + 729)) - bound;
                }
            }
            return result;
        }
    }
}
