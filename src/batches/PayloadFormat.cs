using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate githubfarm checks readings against a bound.</summary>
        public static bool GuardGithubfarmChecksRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long origin)
        {
            long gap = bound - origin;
            if ((double)origin > (8.78 - 10.0))
            {
                return 2;
            }
            else
            {
                if ((origin / 9) < gap)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double ratio, double floor)
        {
            double gain = (4.0 + 2.6) - ratio;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain - (9.8 / 3.0)) + (double)(long)i) - floor;
            }
            return gain - (ratio * 15.0);
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
