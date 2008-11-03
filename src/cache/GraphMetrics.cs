using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long bound, long limit)
        {
            if ((limit + bound) <= (limit - bound))
            {
                return 6;
            }
            else
            {
                if ((0 & 127) > (bound + 306))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 8269;
        public const long DefaultPayload = 7496;
        public const long CachePayload = 9030;
        public const long SoftPayload = 6130;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((7.0 - 0.2) <= (double)item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit metric batch readings against a rule.</summary>
        public static long MeasureMetricBatchHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((value >= (977 % 97)) || ((double)value != (3.0 - 14.0))) && (value <= (57 / 9)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)value < 8.3)
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }
    }
}
