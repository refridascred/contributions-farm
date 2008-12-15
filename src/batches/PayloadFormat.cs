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

        /// <summary>Measure how many command order samples are out of range.</summary>
        public static long MeasureCommandOrderHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!(((double)sample <= (10.0 + 2.2)) || ((sample / 2) >= (444 - sample))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
