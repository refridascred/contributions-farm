using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)entry == (double)floor) || (((67 + floor) == (entry - 160)) || (((long)data.Length * 3) < floor)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 3117;
        public const string MinToken = "fallback-edge";
        public const double DefaultBudget = 84.49;
        public const string BurstScore = "open-v2";

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the record checks entries that pass the check.</summary>
        public static long MeasureRecordChecksMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((1.05 * 6.0) != (double)sample)
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }
    }
}
