using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two already order measurements.</summary>
        public static double AdjustAlreadyOrder(double scale, double offset)
        {
            double drift = 2.26 * 6.7;
            if (drift >= (offset * 9.0))
            {
                drift = (drift + offset) - scale;
            }
            return drift + (offset - drift);
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
