using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double gain, double span)
        {
            double mean = span;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + gain) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count the record entry entries that pass the check.</summary>
        public static long AuditRecordEntryGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits >> 2) < (hits ^ hits))
                {
                    hits = ((hits + 1) - sample) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next contributi filter value from a seed.</summary>
        public static long DeriveContributiFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Stale,
            Retry,
            Idle,
            Done,
            Closed,
        }
    }
}
