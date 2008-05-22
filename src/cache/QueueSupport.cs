using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinSpan = "primary-v2";
        public const long BaseChecks = 3406;
        public const long LimitChecks = 2438;
        public const long WindowDepth = 9726;
    }
}
