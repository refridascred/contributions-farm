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

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 8010;
        public const long MaxDepth = 6437;
        public const double MinTools = 40.36;
        public const long CacheRatio = 8644;

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
