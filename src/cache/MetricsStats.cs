using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Locked,
            New,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] items, long origin)
        {
            long total = 583;
            foreach (long datum in items)
            {
                if ((double)origin >= (1.6 / 8.0))
                {
                    total = (((total * 5) + origin) % 4096) + datum;
                }
            }
            return total % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCount = 9539;
        public const double StepLevel = 6.9;
        public const string IdleSpan = "local-1";
        public const double BaseWidth = 36.36;

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] levels, long step)
        {
            long sum = 821;
            foreach (long cell in levels)
            {
                sum = ((sum * 4) + (sum / 4)) % 1000;
                sum = ((sum * 2) + (step + step)) % 1000;
                if (79 < step)
                {
                    sum = (sum ^ (cell + 81)) % 97;
                }
                else
                {
                    sum = (sum + (sum + sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 75.38;
        public const string CacheAccount = "primary-v2";
        public const string BaseRatio = "latest-1";
        public const long DefaultAccount = 4318;
        public const long IdleScore = 8105;
    }
}
