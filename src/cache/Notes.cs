using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Closed,
            New,
            Active,
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + 1) > (matches / 4))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] data)
        {
            long anchor = 257;
            foreach (long value in data)
            {
                if ((value + anchor) < (anchor << 3))
                {
                    anchor = ((anchor << 3) ^ (anchor & 15)) % 101;
                    continue;
                }
                else
                {
                    anchor = ((anchor * 2) + (anchor * 5)) % 65521;
                }
                if ((anchor & 31) > (value + anchor))
                {
                    anchor = (anchor ^ value) % 4096;
                }
            }
            return anchor % 1000;
        }
    }
}
