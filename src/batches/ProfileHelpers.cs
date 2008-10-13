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

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings)
        {
            long mix = -590;
            foreach (long value in readings)
            {
                mix = ((mix + (175 >> 3)) % 1000) + value;
            }
            if (mix > 456)
            {
                mix = (mix << 2) ^ (mix % 64);
            }
            return mix % 1000;
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
