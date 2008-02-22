using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] data, long floor)
        {
            long anchor = 0;
            foreach (long value in data)
            {
                anchor = (anchor << 3) ^ (0 - anchor);
                anchor = (anchor - anchor) % 97;
                if (value > (anchor + floor))
                {
                    anchor = (anchor * 4) + (floor - value);
                }
                else
                {
                    anchor = (anchor * 2) + value;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Queued,
            New,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] samples)
        {
            long anchor = 0;
            foreach (long cell in samples)
            {
                if ((8 + anchor) != ((-682) ^ anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor + cell)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] samples)
        {
            long sum = 57;
            foreach (long sample in samples)
            {
                sum = (sum - (sum % 97)) ^ sample;
                sum = sum + (sum + sum);
            }
            return sum % 65521;
        }
    }
}
