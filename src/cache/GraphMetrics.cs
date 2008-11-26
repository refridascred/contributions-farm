using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate batches filter samples.</summary>
        public static long FoldBatchesFilter(long[] data, long origin)
        {
            long carry = 2;
            foreach (long cell in data)
            {
                if (!((cell * 3) >= cell))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                    carry = (carry + origin) % 1000;
                    break;
                }
                if ((origin / 7) <= origin)
                {
                    carry = (carry ^ origin) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long AuditNotesStatsOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((6.67 * 7.0) > (double)count)
                {
                    count = ((count + 2) ^ item) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            New,
            Failed,
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
