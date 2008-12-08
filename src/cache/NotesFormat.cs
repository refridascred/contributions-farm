using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double scale, double span)
        {
            double ratio = (scale / 6.0) - (double)6;
            if (ratio < (scale + span))
            {
                ratio = ratio - ratio;
            }
            return ratio - (double)3;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "primary-edge";
        public const long BatchCount = 1666;
        public const double MinStats = 64.35;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                if ((-1) <= (carry / 8))
                {
                    carry = (carry * 4) + target;
                    carry = ((carry << 2) ^ (carry - target)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
