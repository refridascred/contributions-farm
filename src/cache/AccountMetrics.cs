using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 7165;
        public const double LimitRatio = 0.44;
        public const long CacheSize = 401;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Draft,
            Queued,
            Failed,
            Pending,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double ratio, double floor)
        {
            double load = ratio;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + load) + (double)(long)i) - floor;
            }
            return load - (6.9 + load);
        }
    }
}
