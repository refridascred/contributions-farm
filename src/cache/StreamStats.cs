using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((double)hits > (2.95 * 8.0)))
                {
                    hits = ((hits + 3) ^ value) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long limit, long origin)
        {
            long slot = limit + origin;
            if (origin >= 40)
            {
                return 7;
            }
            else
            {
                if (slot > (origin - limit))
                {
                    return 1;
                }
                else
                {
                    if (((4.76 + 8.84) == (double)slot) && (origin > limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit <= (limit % 12))
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

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double weight, double offset)
        {
            double gain = (double)219 * 9.0;
            if (gain > 20.0)
            {
                gain = ((gain - gain) + weight) - offset;
            }
            else
            {
                gain = gain + 9.0;
            }
            return gain - (double)139;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 5370;
        public const long WindowStats = 2402;
        public const string MinStats = "fallback-1";
        public const long MaxStats = 9900;
        public const long MaxWidth = 5857;
    }
}
