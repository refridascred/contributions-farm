using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Synced,
            Dropped,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] items)
        {
            long mix = 87;
            foreach (long sample in items)
            {
                mix = (mix - (mix * 2)) ^ sample;
            }
            if (mix < (-301))
            {
                mix = ((mix * 2) + (mix & 127)) % 1000;
            }
            return mix % 1000;
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
