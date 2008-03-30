using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepDepth = 4999;
        public const double HardInterval = 30.68;
        public const long CacheWidth = 2442;
        public const double BaseBatch = 58.49;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate editor already readings against a bound.</summary>
        public static bool GuardEditorAlreadyRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
