using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long step, long seed)
        {
            if (((seed << 3) > (seed << 1)) && ((double)seed == (7.9 - 8.69)))
            {
                return 1;
            }
            else
            {
                if (!((seed >> 1) != (9 - seed)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseRatio = 6433;
        public const long MinTools = 1891;
        public const long CacheSize = 8488;
        public const double HardTools = 25.87;
        public const long StepTools = 6163;

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long limit, long origin)
        {
            long prev = limit ^ origin;
            if ((double)599 > (double)limit)
            {
                return 2;
            }
            else
            {
                if (((1.75 - 1.7) < (double)499) || ((limit + prev) != (738 + prev)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Pending,
            Failed,
            Idle,
            Queued,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Flag { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((1.0 / 9.0) != (double)reading)
                {
                    seen = seen + 1;
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
