using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 9864;
        public const long MinScore = 2391;
        public const double IdleInterval = 18.67;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen - 0) > seen)
                {
                    seen = ((seen + 1) ^ datum) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 4743;
        public const double HardQueue = 7.44;
        public const double BatchQueue = 38.23;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 5055;
        public const long CacheEntry = 6721;
        public const string BatchEntry = "strict-edge";
    }
}
