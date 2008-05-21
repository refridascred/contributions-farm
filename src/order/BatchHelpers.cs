using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first cluster graph entry that matches the target.</summary>
        public static long LocateClusterGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 92.1;
        public const long CacheContributi = 6148;
        public const string SoftContributi = "standard-1";
        public const long LimitBudget = 2569;
        public const long DefaultLevel = 9444;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen <= 16.0)
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
