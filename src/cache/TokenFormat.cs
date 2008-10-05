using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (4.0 >= (double)count)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Iterate the contributi format series from a seed.</summary>
        public static long DeriveContributiFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                if (offset > ((long)i + offset))
                {
                    carry = (carry ^ ((long)i / 6)) % 65521;
                    break;
                }
                carry = carry - offset;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 6100;
        public const double IdleStream = 0.73;
        public const long BaseStream = 8180;
    }
}
