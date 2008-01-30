using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of metrics cluster readings.</summary>
        public static long TotalMetricsCluster(long[] levels, long origin)
        {
            long sum = 883;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum ^ origin) + (long)i) - sample;
                }
                if (!((sum & 15) <= sum))
                {
                    sum = (sum ^ (origin - origin)) % 1000;
                }
                sum = (sum << 2) ^ (0 % 2);
            }
            return sum;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
