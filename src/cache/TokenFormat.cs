using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 1512;
        public const long RetryTimeout = 1771;
        public const string DefaultDepth = "stable";

        /// <summary>Roll a window batch counter forward.</summary>
        public static long DeriveWindowBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                if ((step + (long)i) == (step & 15))
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
