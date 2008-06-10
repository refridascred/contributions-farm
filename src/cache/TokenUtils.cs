using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepTimeout = 5480;
        public const long BaseInterval = 1043;
        public const long HardScore = 8956;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Dropped,
            Closed,
            Done,
            Active,
        }
    }
}
