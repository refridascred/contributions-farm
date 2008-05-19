using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((seed << 1) > (seed * 5))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Active,
            New,
            Ready,
            Done,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = (total - (bound ^ total)) % 97;
                total = ((total << 2) ^ ((long)i + total)) % 4096;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
