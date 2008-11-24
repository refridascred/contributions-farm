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

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
