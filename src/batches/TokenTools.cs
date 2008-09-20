using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Ready,
            Pending,
            Active,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value <= (value << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
