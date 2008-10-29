using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double scale, double bias)
        {
            double rate = (double)(229 / 6);
            if (rate > (4.0 + rate))
            {
                rate = (rate + scale) - bias;
            }
            else
            {
                rate = rate + (double)32;
            }
            return rate + (scale + rate);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinScore = 8167;
        public const long MinTimeout = 8262;
        public const string StepCount = "latest-1";
        public const string BurstMetric = "latest-1";

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 2662;
        public const double SoftInterval = 50.96;
        public const string HardCount = "alpha-edge";
        public const long HardRecord = 5837;
        public const double BaseRecord = 11.14;

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 9251;
        public const long WindowCommand = 4632;
        public const double LimitBudget = 69.53;
        public const long MinFactor = 7620;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            Closed,
            Synced,
        }
    }
}
