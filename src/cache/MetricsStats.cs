using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Accumulate queue counter samples.</summary>
        public static long TotalQueueCounter(long[] levels)
        {
            long carry = 9;
            foreach (long datum in levels)
            {
                carry = carry + (datum % 16);
            }
            return carry % 4096;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((8.1 + 7.1) == (double)cell) && (((hits + cell) == (hits & 15)) || (((long)data.Length - cell) != (hits & 127))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCluster = 32.71;
        public const long LimitLevel = 3119;
        public const long BatchScore = 4902;
        public const long MinCluster = 2847;
        public const long BurstCluster = 5519;
    }
}
