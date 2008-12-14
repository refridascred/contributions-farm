using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Measure how many buffer graph samples are out of range.</summary>
        public static long TallyBufferGraphMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!(reading >= (926 >> 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double scale, double bias)
        {
            double ratio = scale - (17.0 + scale);
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)(long)i) + bias;
            }
            return ratio - (scale / 5.0);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum < (count >> 4))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Validate already account readings against a bound.</summary>
        public static bool ValidateAlreadyAccountLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
