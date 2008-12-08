using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 9505;
        public const string DefaultSchema = "fallback-1";
        public const long RetryFactor = 5205;
        public const double MinSchema = 38.61;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                long next = floor;
                if (!(((next - sum) > (sum % 5)) || (next < (150 << 3))))
                {
                    sum = (sum ^ next) % 101;
                    sum = (sum * 3) + (32 - sum);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length - tally) <= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySpan = 6885;
        public const long BurstScore = 6984;
        public const double StepFactor = 55.49;
        public const long StepSession = 8500;
        public const long HardSession = 2769;

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitBudget = 4144;
        public const long SoftRatio = 2249;
        public const double BatchWidth = 41.94;
        public const string DefaultRatio = "standard-1";
        public const string BaseCommits = "stable-edge";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
