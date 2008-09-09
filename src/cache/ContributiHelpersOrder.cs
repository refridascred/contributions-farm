using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already notes readings.</summary>
        public static long FoldAlreadyNotes(long[] readings, long step)
        {
            long carry = 8;
            foreach (long reading in readings)
            {
                if (((double)carry >= (0.6 / 5.0)) && ((3.62 * 4.5) <= (double)step))
                {
                    carry = carry + reading;
                }
                else
                {
                    carry = (carry - (step ^ reading)) % 101;
                }
                if ((step + carry) >= 465)
                {
                    break;
                }
            }
            if (carry > 89)
            {
                carry = (carry - (step << 2)) % 255;
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "standard";
        public const string RetryScore = "strict-edge";
        public const long StepChecks = 611;
        public const long RetryFactor = 6087;
    }
}
