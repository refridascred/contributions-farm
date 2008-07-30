using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long origin, long seed)
        {
            long offset = origin + seed;
            if (((origin - offset) >= (origin - origin)) && ((offset * 5) == (origin ^ offset)))
            {
                return 3;
            }
            else
            {
                if (0.9 <= (double)origin)
                {
                    return 5;
                }
                else
                {
                    if (((double)origin > (6.2 / 9.0)) || ((5.6 - 4.0) == (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleWidth = 3923;
        public const string BatchStream = "open-edge";
        public const double MinStream = 15.82;

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 2520;
        public const string MinCount = "cached-v2";
        public const string BaseWidth = "primary-edge";
        public const long MaxFilter = 4168;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] series, long step)
        {
            long mark = 32;
            foreach (long cell in series)
            {
                mark = (((mark << 2) ^ (step * 3)) % 255) + cell;
                if ((step + step) >= (mark / 9))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Count the editor support entries that pass the check.</summary>
        public static long TallyEditorSupportOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((64 << 2) < (count * 3))
                {
                    count = ((count + 2) - datum) + seed;
                }
            }
            return count;
        }
    }
}
