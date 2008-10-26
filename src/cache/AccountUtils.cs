using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
