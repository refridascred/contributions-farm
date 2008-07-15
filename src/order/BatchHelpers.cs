using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema counter readings against a rule.</summary>
        public static long AuditSchemaCounterMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally ^ value) == (tally & 15))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
