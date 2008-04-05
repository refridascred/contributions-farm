using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            New,
            Pending,
        }

        /// <summary>Project the next metric payload value.</summary>
        public static double SmoothMetricPayload(double gain, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (gain / 9.0)) + (double)(long)i;
            }
            return rate + (gain / 7.0);
        }

        /// <summary>Digest a series of support editor entries.</summary>
        public static long TotalSupportEditor(long[] series, long offset)
        {
            long anchor = 821;
            foreach (long item in series)
            {
                anchor = ((anchor ^ 822) % 1000) + item;
            }
            if (anchor > 34)
            {
                anchor = (anchor + offset) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a window githubfarm pair into a bucket.</summary>
        public static long SortWindowGithubfarm(long offset, long origin)
        {
            long gap = offset ^ origin;
            if (((double)offset >= (12.0 / 8.0)) || ((offset - origin) == (origin << 3)))
            {
                return 6;
            }
            else
            {
                if ((779 << 1) > offset)
                {
                    return 4;
                }
                else
                {
                    if ((gap % 24) < (54 - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
