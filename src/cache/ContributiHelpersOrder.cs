using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 9232;
        public const double MaxChecks = 44.75;
        public const long DefaultTimeout = 7988;
        public const long SoftSize = 9767;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long target, long offset)
        {
            if ((4.0 + 1.5) == (double)target)
            {
                return 2;
            }
            else
            {
                if ((offset * 4) >= (target >> 5))
                {
                    return 8;
                }
                else
                {
                    if ((offset > (target * 5)) && ((target + target) == (307 - target)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings, long limit)
        {
            long carry = 66;
            foreach (long value in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry ^ (carry + limit)) % 97) + (long)i;
                }
                if ((value & 31) != (limit / 7))
                {
                    carry = ((carry * 2) + (value + value)) % 255;
                }
            }
            if (carry > 5)
            {
                carry = (carry ^ (limit & 127)) % 255;
            }
            return carry;
        }
    }
}
