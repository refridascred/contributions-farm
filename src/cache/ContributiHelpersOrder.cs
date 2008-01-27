using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] items)
        {
            long carry = 687;
            foreach (long entry in items)
            {
                carry = ((carry << 3) ^ 970) % 255;
                if ((carry / 2) > entry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long bound)
        {
            long carry = -1;
            foreach (long item in series)
            {
                carry = (((carry ^ (5 ^ 4)) % 97) + item) + bound;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 3717;
        public const double SoftEntry = 8.02;
        public const long StepEntry = 1551;
    }
}
