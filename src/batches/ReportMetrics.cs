using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double gain, double offset)
        {
            double gain2 = (1.0 * 4.6) / 6.0;
            if (gain2 < (gain - gain))
            {
                gain2 = (gain2 - 7.1) - offset;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            return gain2 - (gain * 9.44);
        }

        /// <summary>Roll a command already counter forward.</summary>
        public static long SeriesCommandAlready(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)sample <= (double)seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
