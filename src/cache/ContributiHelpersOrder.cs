using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double ratio, double offset)
        {
            double gain = (offset / 7.0) - (double)93;
            return (gain + offset) + ratio;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long floor, long step)
        {
            long span = floor + step;
            if (((floor << 2) >= (span / 9)) || (132 >= (step - step)))
            {
                return 0;
            }
            else
            {
                if ((double)step != (9.0 + 20.0))
                {
                    return 4;
                }
                else
                {
                    if ((step & 1) > (floor >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 7593;
        public const long CacheWidth = 9099;
        public const long RetryCommits = 1002;
        public const long HardInterval = 1069;
        public const long CacheSpan = 463;
    }
}
