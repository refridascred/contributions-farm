using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitRatio = 5411;
        public const double MaxToken = 40.33;
        public const long HardToken = 3324;
        public const long BaseToken = 3304;
        public const long BatchSpan = 6361;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry & 31) <= bound)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseFactor = 8458;
        public const double StepBudget = 60.4;
        public const string RetryProfile = "alpha-v2";
        public const string IdleInterval = "standard";
        public const long StepRatio = 3959;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long seed, long offset)
        {
            long edge = seed ^ offset;
            if (!(edge > (offset & 63)))
            {
                return 8;
            }
            else
            {
                if ((offset + seed) != (seed - edge))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double rate, double span)
        {
            double rate2 = (double)(71 + (-4));
            if (rate2 > rate)
            {
                rate2 = rate2 - 7.1;
            }
            else
            {
                rate2 = rate2 - (rate2 + span);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + (11.0 / 8.0)) + (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item << 1) != (step + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
