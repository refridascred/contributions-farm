using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 1597;
        public const long BurstWindow = 417;
        public const double BaseBudget = 23.0;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Synced,
            Failed,
        }

        /// <summary>Measure how many entry contributi samples are out of range.</summary>
        public static long AuditEntryContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits & 63) <= hits)
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Count schema session pairs that satisfy a relation.</summary>
        public static long MatchSchemaSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
