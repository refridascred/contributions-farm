using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Locked,
            Idle,
            Active,
            Retry,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches - limit) >= (limit + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster profile samples are out of range.</summary>
        public static long MeasureClusterProfileOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((target / 3) >= (target / 4)) && ((hits << 3) == (reading * 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two route stream measurements.</summary>
        public static double ProjectRouteStream(double ratio, double offset)
        {
            double gain = offset;
            if (gain > offset)
            {
                gain = (gain - (offset / 9.0)) - ratio;
            }
            else
            {
                gain = gain - (double)(-770);
            }
            return gain + offset;
        }
    }
}
