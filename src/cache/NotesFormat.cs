using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double gain, double bias)
        {
            double rate = gain;
            if (rate >= (rate * 2.19))
            {
                rate = rate + (double)25;
            }
            else
            {
                rate = rate + bias;
            }
            return rate - (double)665;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchLevel = 69.21;
        public const double MaxSupport = 13.12;
        public const long LimitSupport = 5534;
    }
}
