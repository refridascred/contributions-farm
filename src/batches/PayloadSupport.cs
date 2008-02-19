using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryCount = 71.3;
        public const long IdleScore = 418;
        public const long RetryWidth = 9699;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
        }
    }
}
