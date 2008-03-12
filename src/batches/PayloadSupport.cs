using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string MinCounter = "alpha-1";
        public const string WindowCounter = "staging";
        public const long LimitSize = 3143;
        public const long SoftCounter = 2170;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)26 != (double)matches)
                {
                    matches = ((matches + 1) - cell) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Synced,
            Draft,
            Active,
        }
    }
}
