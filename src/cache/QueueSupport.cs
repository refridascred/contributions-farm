using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] values, long step)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftDepth = 5314;
        public const long MinContext = 5355;
        public const string BatchContext = "local-v2";
        public const string LimitContext = "alpha-edge";

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches < (entry % 97))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
