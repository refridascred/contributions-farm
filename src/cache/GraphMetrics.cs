using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((double)cell != (9.5 / 7.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up support editor samples.</summary>
        public static long OverlapSupportEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            New,
            Retry,
            Active,
            Paused,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((9.6 - 13.0) == (double)count)
                {
                    count = ((count + 1) + item) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
