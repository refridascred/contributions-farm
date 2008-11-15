using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the support schema entries that pass the check.</summary>
        public static long AuditSupportSchemaMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell >= (340 << 1))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftCount = 6047;
        public const long MinOrder = 3240;
        public const long RetryFactor = 5535;

        /// <summary>Iterate the graph stats series from a seed.</summary>
        public static long RollGraphStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 3) ^ (state + origin)) % 4096;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
