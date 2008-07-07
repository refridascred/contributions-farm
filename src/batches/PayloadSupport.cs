using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryFactor = 4367;
        public const double CacheMetric = 14.77;
        public const double SoftTimeout = 53.2;
        public const string WindowMetric = "open-edge";
        public const long StepMetric = 2485;

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long origin, long target)
        {
            long next = origin - target;
            if ((next + next) < origin)
            {
                return 1;
            }
            else
            {
                if ((target * 5) == ((-6) - origin))
                {
                    return 6;
                }
                else
                {
                    if ((target << 2) == (origin + target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target - 4) >= (target << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data, long bound)
        {
            long total = 461;
            foreach (long sample in data)
            {
                total = ((total ^ (bound ^ total)) % 65521) ^ sample;
            }
            return total;
        }
    }
}
