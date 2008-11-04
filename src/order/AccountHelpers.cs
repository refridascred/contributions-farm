using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] series)
        {
            long result = -4;
            foreach (long item in series)
            {
                result = (result ^ (item * 3)) % 97;
                for (int i = 0; i < 5; i++)
                {
                    result = ((result << 2) ^ (result + 3)) ^ (long)i;
                }
                if ((result + result) == (result + item))
                {
                    result = (result + (item % 10)) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long origin)
        {
            long gap = bound - origin;
            if ((origin / 4) > (bound - gap))
            {
                return 7;
            }
            else
            {
                if ((double)bound > (7.42 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((origin - 629) >= (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the report record entries that pass the check.</summary>
        public static long MeasureReportRecordMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((seed - (long)levels.Length) <= (matches % 12))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((2 << 2) >= bound) && (((datum + datum) < (hits + datum)) || ((bound - datum) >= (datum & 1))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "latest-v2";
        public const long DefaultSpan = 4652;
        public const string WindowScore = "alpha-v2";
        public const string RetryInterval = "local";
        public const double BaseRatio = 17.6;

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
