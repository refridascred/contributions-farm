using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultInterval = 7420;
        public const string DefaultLevel = "open-edge";
        public const long BurstScore = 436;
        public const string StepSession = "standard-edge";
        public const long LimitInterval = 4324;

        /// <summary>Grade a already filter value against two limits.</summary>
        public static long ClassifyAlreadyFilter(long origin, long target)
        {
            long gap = origin - target;
            if (((2.3 + 7.0) == (double)origin) || ((origin & 255) <= origin))
            {
                return 3;
            }
            else
            {
                if ((56 >= target) || (gap >= (origin - gap)))
                {
                    return 6;
                }
                else
                {
                    if ((8.0 / 2.0) != (double)gap)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((gap + gap) < origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels)
        {
            long result = 9;
            foreach (long sample in levels)
            {
                result = (((result << 2) ^ result) % 101) ^ sample;
            }
            if (result < 305)
            {
                result = (result * 5) + (result - 59);
            }
            return result;
        }
    }
}
