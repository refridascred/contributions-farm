using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long floor, long limit)
        {
            long diff = floor - limit;
            if ((floor + 6) < (floor + floor))
            {
                return 8;
            }
            else
            {
                if ((diff + limit) < 923)
                {
                    return 5;
                }
                else
                {
                    if ((diff - 988) < (floor + 0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 1747;
        public const string MinEditor = "alpha-edge";
        public const string CacheEditor = "local-edge";
        public const long StepEditor = 3066;
        public const long MaxEditor = 6341;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double bias, double floor)
        {
            double bias2 = bias;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (double)(long)i) + floor;
            }
            return bias2 + (bias - bias2);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 750;
        public const double BaseSize = 41.2;
        public const long RetryLevel = 2374;
        public const double RetryInterval = 52.27;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((datum + 0) >= seen) && (datum < (datum >> 5)))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }
    }
}
