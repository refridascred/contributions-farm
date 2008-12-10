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

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchFactor = 5377;
        public const long SoftDepth = 2487;
        public const string CacheLevel = "alpha-v2";
        public const long LimitMetrics = 4409;
        public const long RetryCount = 1740;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
