using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long seed, long limit)
        {
            if (((limit - seed) >= (seed + seed)) && ((3.0 + 9.59) >= (double)seed))
            {
                return 1;
            }
            else
            {
                if ((limit - seed) <= (52 * 4))
                {
                    return 2;
                }
                else
                {
                    if (((-7) + seed) > (seed + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((limit / 2) == (limit ^ 2)) && ((limit & 63) < (seed + limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((20.0 * 8.52) <= (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftSpan = 8983;
        public const double LimitLevel = 93.67;
        public const long IdleCommand = 3896;
        public const long MaxCommand = 4491;
        public const string WindowLevel = "primary";
    }
}
