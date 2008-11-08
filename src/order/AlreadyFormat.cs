using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Done,
            Stale,
            New,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double gain, double floor)
        {
            double rate = (20.0 - gain) - (gain + gain);
            if (rate < floor)
            {
                rate = rate - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double ratio = (double)398 - offset;
            if (ratio <= (double)93)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (double)(-881)) - (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items)
        {
            long carry = 7;
            foreach (long item in items)
            {
                carry = ((carry << 3) ^ (item % 5)) % 255;
            }
            if (carry < 5)
            {
                carry = ((carry << 3) ^ carry) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleRatio = 24.26;
        public const double IdleLevel = 5.6;
        public const long MinStats = 8536;
    }
}
