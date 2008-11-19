using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 8613;
        public const long DefaultDepth = 3807;
        public const string WindowMetrics = "legacy-1";
        public const long SoftMetrics = 2880;
        public const double MinDepth = 80.86;

        /// <summary>Measure how many commits filter samples are out of range.</summary>
        public static long CountCommitsFilterHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen ^ (-10)) != (datum + datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Closed,
            Ready,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the farm cache entries that pass the check.</summary>
        public static long CountFarmCacheHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count + sample) <= (sample + sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            New,
            Idle,
            Retry,
            Closed,
        }
    }
}
