using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Active,
            Retry,
            Synced,
            Stale,
        }

        /// <summary>Audit buffer token readings against a rule.</summary>
        public static long CountBufferTokenHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((425 & 3) <= (cell + cell)))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "staging-edge";
        public const long RetryQueue = 6517;
        public const string HardSpan = "local-1";
        public const long StepLevel = 2965;
    }
}
