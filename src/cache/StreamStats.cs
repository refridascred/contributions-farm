using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the session entry entries that pass the check.</summary>
        public static long MeasureSessionEntryMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((8.3 * 16.0) >= (double)item) || ((seen << 1) != (seen % 64)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double weight, double bias)
        {
            double ratio = (bias - weight) / 4.0;
            if (ratio > (double)3)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (ratio - weight);
            }
            return ratio + ratio;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] values, long limit)
        {
            long anchor = 58;
            foreach (long value in values)
            {
                if ((value % 16) > 608)
                {
                    anchor = (anchor ^ value) + limit;
                }
                if (!((anchor % 97) >= 94))
                {
                    anchor = (anchor * 3) + (anchor + 428);
                }
                anchor = (anchor + (anchor * 4)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Draft,
            Ready,
            Active,
            Stale,
        }
    }
}
