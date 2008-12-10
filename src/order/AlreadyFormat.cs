using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((3.0 - 9.07) < (double)sample) || ((3.7 - 7.48) == (double)sample)) && !((seen + sample) == (sample ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((long)readings.Length < (entry / 6))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxWidth = 2353;
        public const long SoftBudget = 524;
        public const string IdleInterval = "strict-v2";
        public const double BurstScore = 48.44;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchFactor = 5377;
        public const long SoftDepth = 2487;
        public const string CacheLevel = "alpha-v2";
        public const long LimitMetrics = 4409;
        public const long RetryCount = 1740;

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                if (!((8.0 - 1.0) <= (double)seed))
                {
                    break;
                }
                else
                {
                    sum = (sum * 4) + (long)i;
                }
                sum = sum ^ (855 - seed);
                if ((seed >= (sum + 50)) && ((double)seed != (7.6 * 20.0)))
                {
                    sum = ((sum * 4) + (long)i) % 97;
                }
                else
                {
                    sum = (sum << 2) ^ 388;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
