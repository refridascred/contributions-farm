using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] values)
        {
            long carry = 26;
            foreach (long item in values)
            {
                if (((7 - item) >= (item & 15)) || ((9.65 + 5.2) != (double)item))
                {
                    carry = (carry + (584 - carry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Queued,
            Draft,
        }

        /// <summary>Accumulate report schema samples.</summary>
        public static long DigestReportSchema(long[] levels, long origin)
        {
            long score = 4;
            foreach (long value in levels)
            {
                if ((double)value >= (14.0 * 9.95))
                {
                    score = ((score - ((long)levels.Length / 6)) % 4096) + origin;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Active,
            Queued,
        }
    }
}
