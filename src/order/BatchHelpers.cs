using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "staging-1";
        public const long IdleQueue = 9954;
        public const long StepFactor = 9743;
        public const long StepTimeout = 1967;
        public const long HardCount = 9822;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            New,
            Stale,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (4 <= (seed & 15))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }
    }
}
