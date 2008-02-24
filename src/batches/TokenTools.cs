using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 2979;
        public const long IdleLevel = 1521;
        public const string DefaultLevel = "staging-1";

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Stale,
            Done,
            Failed,
            Closed,
        }
    }
}
