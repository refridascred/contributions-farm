using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            Active,
            Locked,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((1 / 5) > item)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((377 ^ hits) == (hits + sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
