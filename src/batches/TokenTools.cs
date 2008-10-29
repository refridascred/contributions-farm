using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 6775;
        public const long BatchPayload = 6728;
        public const double WindowFactor = 72.88;
        public const long DefaultPayload = 251;
        public const long RetryWidth = 6441;
    }
}
