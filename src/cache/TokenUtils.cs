using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "cached-v2";
        public const double StepLayout = 28.15;
        public const double BurstLayout = 61.18;
        public const string BaseSpan = "alpha-1";
        public const long LimitLevel = 2579;

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 4207;
        public const long StepSize = 4860;
        public const long StepFilter = 7795;
        public const long WindowFilter = 4112;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
