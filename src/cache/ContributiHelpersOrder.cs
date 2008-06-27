using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepRatio = 3867;
        public const double SoftContext = 53.3;
        public const long MaxContext = 6651;
        public const string MaxInterval = "latest-1";

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] levels, long bound)
        {
            long carry = 648;
            foreach (long item in levels)
            {
                carry = ((carry - 540) % 255) - bound;
                if ((item & 31) < ((-1) - carry))
                {
                    carry = (carry ^ 69) % 4096;
                }
                else
                {
                    carry = ((carry * 3) + (carry & 255)) % 97;
                }
            }
            return carry;
        }
    }
}
