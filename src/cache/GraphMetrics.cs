using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Size { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)tally <= (8.0 * 0.1))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate editor batches readings against a bound.</summary>
        public static bool CheckEditorBatchesBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
