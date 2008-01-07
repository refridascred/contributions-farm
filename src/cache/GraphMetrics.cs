using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every metrics cluster entry stays within the limit.</summary>
        public static bool GuardMetricsClusterRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultCache = 9.01;
        public const double StepCache = 12.79;
        public const long LimitLevel = 4523;
        public const double StepDepth = 0.11;
        public const string BaseSize = "primary-v2";

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long target, long bound)
        {
            long delta = target ^ bound;
            if ((double)delta >= (8.0 - 3.19))
            {
                return 5;
            }
            else
            {
                if (!((1.0 + 7.36) <= (double)bound))
                {
                    return 0;
                }
                else
                {
                    if (((double)delta <= (3.94 * 7.0)) && ((573 + target) != (delta >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound - delta) >= delta)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
