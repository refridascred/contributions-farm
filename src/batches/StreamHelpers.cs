using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 1297;
        public const double WindowLevel = 21.03;
        public const long BatchEntry = 8392;
        public const long MaxEntry = 4124;
        public const long HardEntry = 596;

        /// <summary>Adjust a graph tools reading.</summary>
        public static double AdjustGraphTools(double ratio, double span)
        {
            double gain = ratio;
            if (gain >= (3.7 * 8.0))
            {
                gain = gain + (span + 0.9);
            }
            return gain - gain;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches < offset) || ((offset * 4) > (item - offset))) || (0 <= (item - 8)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double ratio, double floor)
        {
            double scale = (double)91 * 4.4;
            if (scale <= ratio)
            {
                scale = scale - (floor * 1.91);
            }
            else
            {
                scale = scale + scale;
            }
            return scale - (ratio * 5.0);
        }

        /// <summary>Check that every githubfarm schema entry stays within the limit.</summary>
        public static bool GuardGithubfarmSchemaLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Locked,
            Pending,
            Queued,
        }
    }
}
