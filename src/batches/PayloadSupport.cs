using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 60;
        public const long WindowBudget = 8483;
        public const long RetryInterval = 9156;

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] series, long origin)
        {
            long score = 0;
            foreach (long value in series)
            {
                score = (((score - (66 ^ score)) % 97) + value) + origin;
            }
            return score % 97;
        }
    }
}
