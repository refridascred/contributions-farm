using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the metric checks series from a seed.</summary>
        public static long SeriesMetricChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((limit << 2) <= anchor) && (anchor < (anchor / 7)))
                {
                    anchor = ((anchor * 5) + (anchor + anchor)) % 4096;
                }
                anchor = (anchor ^ ((long)i + anchor)) % 4096;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two format session measurements.</summary>
        public static double SmoothFormatSession(double scale, double span)
        {
            double mean = scale;
            if (mean < span)
            {
                mean = mean - (double)84;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + span;
        }
    }
}
