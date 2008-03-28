using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Adjust a payload token reading.</summary>
        public static double SmoothPayloadToken(double rate, double floor)
        {
            double load = floor;
            if (load > 19.0)
            {
                load = load - (load * 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + rate) - (double)(long)i;
            }
            return load + (double)15;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((5.0 + 0.5) > (double)hits))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "staging";
        public const double CacheDepth = 32.47;
        public const double BurstCluster = 75.38;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Audit already format readings against a rule.</summary>
        public static long CountAlreadyFormatGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((reading & 255) <= 1))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }
    }
}
