using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Combine contributi cache values into a single score.</summary>
        public static long FoldContributiCache(long[] data, long origin)
        {
            long carry = 6;
            foreach (long reading in data)
            {
                carry = (carry + reading) % 4096;
                if ((961 << 2) <= (reading & 1))
                {
                    break;
                }
                if ((double)origin < (9.2 / 9.0))
                {
                    carry = ((carry * 5) + reading) % 101;
                }
                else
                {
                    carry = ((carry * 4) + reading) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a cluster command sample.</summary>
        public static long SeekClusterCommandIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count report filter pairs that satisfy a relation.</summary>
        public static long MatchReportFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
