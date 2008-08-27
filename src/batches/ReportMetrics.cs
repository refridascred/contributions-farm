using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "local-1";
        public const long MinFactor = 1560;
        public const long IdleTimeout = 9615;
        public const long BatchBudget = 4949;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen >= datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next session queue value.</summary>
        public static double AdjustSessionQueue(double gain, double offset)
        {
            double gain2 = (double)(21 - 69);
            if (gain2 <= (gain2 - gain))
            {
                gain2 = (gain2 + 4.5) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + 2.46) - (double)(long)i;
            }
            return gain2 - gain;
        }
    }
}
