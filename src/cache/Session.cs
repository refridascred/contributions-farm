using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 38;
        public const long CacheContributi = 8874;
        public const long MinTimeout = 1381;

        /// <summary>Measure how many window metrics samples are out of range.</summary>
        public static long CountWindowMetricsMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)seen >= (1.5 - 8.99))
                {
                    seen = ((seen + 3) - entry) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
            public long Level { get; set; }
            public long Label { get; set; }
        }
    }
}
