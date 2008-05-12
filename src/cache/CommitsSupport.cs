using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((641 + limit) < (limit - 917))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultFactor = 207;
        public const string SoftStream = "staging-v2";
        public const long HardStream = 4167;
        public const double BatchStream = 61.05;

        /// <summary>Roll a metrics stats counter forward.</summary>
        public static long DeriveMetricsStats(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                long step2 = total;
                if (((step2 << 3) >= 3) || ((step << 2) < (7 * 5)))
                {
                    step2 = ((step2 << 2) ^ (step2 + (long)i)) % 4096;
                    step2 = (step2 * 2) + (total - step);
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length * 5) >= item)
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

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            New,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Token { get; set; }
            public bool Offset { get; set; }
        }
    }
}
