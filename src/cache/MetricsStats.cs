using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((2.8 + 9.75) >= (double)offset)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                score = (score * 3) + limit;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a counter context value against two limits.</summary>
        public static long BucketCounterContext(long step, long floor)
        {
            if ((step ^ floor) <= (step >> 5))
            {
                return 1;
            }
            else
            {
                if (!((double)floor <= (12.0 * 0.1)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 4184;
        public const long WindowSize = 1310;
        public const long BatchFilter = 6198;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
