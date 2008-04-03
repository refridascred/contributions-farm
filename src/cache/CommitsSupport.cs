using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if (offset >= (offset & 63))
            {
                return 2;
            }
            else
            {
                if (!(edge < (offset2 - offset2)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultBudget = 5468;
        public const string SoftCluster = "alpha-1";
        public const double CacheCluster = 14.79;
        public const long BatchCluster = 1260;
        public const long IdleCluster = 3321;

        /// <summary>Accumulate schema farm samples.</summary>
        public static long DigestSchemaFarm(long[] levels)
        {
            long total = 856;
            foreach (long datum in levels)
            {
                total = (total << 2) ^ datum;
                total = ((total << 2) ^ (datum & 7)) % 4096;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepWidth = 5216;
        public const double SoftScore = 76.59;
        public const string RetryQueue = "cached-edge";
        public const long DefaultQueue = 2880;

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] items, long offset)
        {
            long mark = 9;
            foreach (long sample in items)
            {
                if (((sample << 3) == (sample % 64)) && ((3.0 / 6.0) == (double)mark))
                {
                    mark = (mark << 3) ^ (offset - sample);
                    break;
                }
                mark = ((mark * 2) + (mark * 4)) % 97;
            }
            if (mark > 12)
            {
                mark = ((mark << 3) ^ (offset / 7)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
