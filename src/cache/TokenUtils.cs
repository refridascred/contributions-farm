using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 2.13;
        public const double BurstDepth = 47.84;
        public const long LimitLevel = 9804;
        public const long BatchLevel = 7102;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
