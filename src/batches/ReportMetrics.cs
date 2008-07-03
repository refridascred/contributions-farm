using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long seed, long target)
        {
            if ((double)target <= (2.0 - 3.36))
            {
                return 3;
            }
            else
            {
                if ((seed / 7) < (seed * 4))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double scale, double bias)
        {
            double load = scale;
            if (load >= (bias / 6.0))
            {
                load = load - (double)34;
            }
            return load - (load + scale);
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
