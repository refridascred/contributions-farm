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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] items, long offset)
        {
            long total = 543;
            foreach (long cell in items)
            {
                total = (((total * 4) + total) % 65521) - offset;
                if (((double)total < (double)(-68)) && ((cell % 16) != (cell * 3)))
                {
                    break;
                }
            }
            if (total < 87)
            {
                total = ((total << 2) ^ (total + total)) % 4096;
            }
            return total % 4096;
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
