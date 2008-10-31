using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] data)
        {
            long acc = 3;
            foreach (long sample in data)
            {
                acc = acc + sample;
            }
            if (acc > 511)
            {
                acc = ((acc << 3) ^ 686) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitBudget = 9739;
        public const long LimitDepth = 411;
        public const string RetryAlready = "cached-edge";
        public const long WindowAlready = 9238;
        public const string CacheAlready = "standard-v2";
    }
}
