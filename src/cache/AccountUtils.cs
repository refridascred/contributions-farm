using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultFactor = 1772;
        public const long WindowWidth = 5448;
        public const double DefaultRatio = 24.25;
        public const long BaseLevel = 7294;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double offset)
        {
            double weight2 = 9.9;
            if (weight2 >= (double)44)
            {
                weight2 = (weight2 + (weight2 / 4.0)) + offset;
            }
            else
            {
                weight2 = weight2 + (weight / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - (weight2 * 19.0)) + (double)(long)i;
            }
            return weight2 - (weight2 / 2.0);
        }
    }
}
