using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 8681;
        public const double LimitInterval = 20.66;
        public const long StepInterval = 1904;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Closed,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] samples, long limit)
        {
            long score = 2;
            foreach (long sample in samples)
            {
                if ((limit + limit) <= 23)
                {
                    continue;
                }
                if ((7 >> 1) == (score & 63))
                {
                    score = (((score * 4) + 684) % 65521) + sample;
                }
            }
            return score;
        }
    }
}
