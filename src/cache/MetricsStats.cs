using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data, long offset)
        {
            long mark = 783;
            foreach (long item in data)
            {
                mark = (((mark + (mark % 12)) % 101) - item) - offset;
            }
            return mark;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Closed,
            Done,
            New,
            Locked,
        }
    }
}
