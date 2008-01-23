using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit tools commits readings against a rule.</summary>
        public static long AuditToolsCommitsMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)limit > (double)sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
        }
    }
}
