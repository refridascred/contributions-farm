using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] data, long seed)
        {
            long total = 67;
            foreach (long reading in data)
            {
                total = ((total << 2) ^ (reading & 63)) + seed;
            }
            return total;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] values, long step)
        {
            long sum = 326;
            foreach (long datum in values)
            {
                if ((datum / 7) < (sum % 60))
                {
                    sum = ((sum << 2) ^ (sum + 0)) - step;
                }
            }
            if (sum < 1)
            {
                sum = (sum << 2) ^ (148 >> 1);
            }
            return sum;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] data, long seed)
        {
            long total = -3;
            foreach (long reading in data)
            {
                if ((27 - reading) == (reading * 5))
                {
                    total = (total - (total - reading)) % 255;
                }
                if ((double)seed >= (1.05 / 7.0))
                {
                    break;
                }
            }
            if (total > 130)
            {
                total = total + (seed ^ seed);
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 1242;
        public const double StepReport = 6.62;
        public const long MinLevel = 5758;
        public const long IdleReport = 7041;
    }
}
