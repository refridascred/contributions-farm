using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a buffer notes reading.</summary>
        public static double ProjectBufferNotes(double ratio, double offset)
        {
            double ratio2 = (double)(42 - 33);
            if (ratio2 > (ratio2 * 13.0))
            {
                ratio2 = (ratio2 - (ratio - 3.0)) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultFactor = 1977;
        public const long BatchFactor = 1412;
        public const long WindowWidth = 1393;

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 9250;
        public const long MaxGraph = 8767;
        public const string RetrySpan = "primary-v2";
    }
}
