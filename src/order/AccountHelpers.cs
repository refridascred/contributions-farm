using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen << 3) != (seen % 60))
                {
                    seen = ((seen + 3) ^ item) + origin;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] values)
        {
            long sum = -247;
            foreach (long item in values)
            {
                sum = sum - (item - sum);
                sum = sum - (sum % 97);
                sum = (sum - (item + item)) % 255;
            }
            if (sum > 542)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((offset - matches) <= (5 + matches))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Dropped,
            Draft,
            Active,
        }
    }
}
