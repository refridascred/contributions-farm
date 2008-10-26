using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double weight, double bias)
        {
            double ratio = bias;
            if (ratio <= 17.0)
            {
                ratio = (ratio - (double)170) - weight;
            }
            else
            {
                ratio = ratio + (double)909;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            New,
            Failed,
        }
    }
}
