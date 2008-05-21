using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxWidth = "open-v2";
        public const double LimitDepth = 13.24;
        public const long SoftCache = 7141;
        public const long WindowFactor = 8849;
        public const string CacheInterval = "legacy-1";

        /// <summary>Check that every session filter entry stays within the limit.</summary>
        public static bool ValidateSessionFilterRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Ready,
            Queued,
            Locked,
            New,
        }
    }
}
