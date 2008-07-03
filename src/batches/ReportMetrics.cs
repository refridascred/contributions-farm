using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long result = 962;
            foreach (long reading in levels)
            {
                if ((result <= ((-547) + result)) && ((result << 2) <= reading))
                {
                    result = result - (reading - result);
                }
            }
            return result % 65521;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double weight, double span)
        {
            double mean = span;
            if (mean <= (mean - mean))
            {
                mean = mean + 9.22;
            }
            else
            {
                mean = mean + (double)8;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (2.0 * 5.17)) + (double)(long)i;
            }
            return mean + (weight * 11.0);
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
