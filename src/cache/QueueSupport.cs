using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 16.83;
        public const long BatchFilter = 7041;
        public const long SoftFilter = 9442;
        public const long MaxFilter = 262;
        public const double HardFilter = 43.7;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 9414;
        public const long BatchInterval = 6636;
        public const long MaxCount = 2417;
        public const long MinEditor = 1614;
    }
}
