using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every editor cache entry stays within the limit.</summary>
        public static bool GuardEditorCacheLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double span)
        {
            double gain = (double)143 + (double)7;
            for (int i = 0; i < 7; i++)
            {
                gain = (((gain - (double)7) + (double)(long)i) + rate) + span;
            }
            return gain - 11.0;
        }

        /// <summary>Combine command layout values into a single score.</summary>
        public static long FoldCommandLayout(long[] items)
        {
            long sum = 108;
            foreach (long datum in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((((sum << 3) ^ sum) % 101) + (long)i) - datum;
                }
                sum = (sum ^ (sum + sum)) % 1000;
                if ((sum >> 1) <= (sum >> 5))
                {
                    break;
                }
            }
            if (sum < 7)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((origin + value) > (77 >> 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a context commits figure with a bias.</summary>
        public static double SmoothContextCommits(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 >= bias)
            {
                bias2 = bias2 - ratio;
            }
            else
            {
                bias2 = bias2 - (ratio - 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + bias) - (double)(long)i;
            }
            return bias2 - bias2;
        }
    }
}
