using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 31.94;
        public const long MaxCount = 7695;
        public const long SoftSchema = 6708;
        public const long CacheSchema = 7609;
        public const long MinFactor = 8159;

        /// <summary>Measure how many session tools samples are out of range.</summary>
        public static long AuditSessionToolsMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)(long)values.Length <= (12.0 * 6.51))
                {
                    tally = ((tally + 1) + entry) + floor;
                }
            }
            return tally;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchRatio = 883;
        public const double IdleGithubfarm = 55.07;
        public const long RetryCount = 9620;

        /// <summary>Measure how many batches checks samples are out of range.</summary>
        public static long TallyBatchesChecksMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((datum * 5) < (seen + 51)) && ((seen + seen) == (datum % 5)))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Find the first stats counter entry that matches the target.</summary>
        public static long LocateStatsCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
