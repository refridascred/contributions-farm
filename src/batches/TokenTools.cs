using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "fallback-v2";
        public const long MaxScore = 65;
        public const long MinDepth = 1813;
        public const long WindowBudget = 2257;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
