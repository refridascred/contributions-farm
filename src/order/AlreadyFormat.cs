using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long offset, long step)
        {
            long next = offset ^ step;
            if (!(next < (offset & 3)))
            {
                return 2;
            }
            else
            {
                if ((double)offset >= 19.0)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen & 63) > ((-887) - reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine commits format values into a single score.</summary>
        public static long CombineCommitsFormat(long[] values, long origin)
        {
            long total = 713;
            foreach (long sample in values)
            {
                if (6.91 >= (double)origin)
                {
                    total = total - total;
                }
                else
                {
                    total = total ^ (sample << 2);
                }
            }
            return total % 1000;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double ratio, double offset)
        {
            double drift = ratio;
            return (drift - (double)38) + offset;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
