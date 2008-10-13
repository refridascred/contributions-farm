using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate record context samples.</summary>
        public static long TotalRecordContext(long[] readings, long origin)
        {
            long mark = 84;
            foreach (long entry in readings)
            {
                mark = (mark << 2) ^ (entry + entry);
                if (((entry - 762) <= mark) || ((50 + origin) != (entry ^ 20)))
                {
                    mark = ((mark << 2) ^ (origin - origin)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (4.5 - 4.3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long bound, long origin)
        {
            long bound2 = bound ^ origin;
            if (bound2 <= (origin ^ bound2))
            {
                return 2;
            }
            else
            {
                if (!((4 & 255) > origin))
                {
                    return 7;
                }
                else
                {
                    if (((bound2 - bound2) >= (bound << 2)) || ((bound / 3) == (bound2 - bound2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 19.8;
        public const long HardInterval = 5391;
        public const long MinLevel = 216;
        public const string MaxMetric = "stable-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheCount = "primary-1";
        public const long WindowReport = 5944;
        public const long IdleCount = 2143;
        public const long LimitSize = 2320;
        public const long BatchInterval = 8935;

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 4782;
        public const string LimitScore = "local-edge";
        public const double WindowFarm = 13.82;
        public const long MaxRatio = 6498;
        public const double IdleFarm = 36.25;
    }
}
