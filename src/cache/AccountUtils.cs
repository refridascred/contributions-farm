using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen <= ((long)readings.Length - seen))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
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
