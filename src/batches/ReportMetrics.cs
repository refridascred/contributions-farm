using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double ratio, double floor)
        {
            double rate = (double)2 + (double)323;
            if (rate <= floor)
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate - (rate - 2.4);
            }
            return rate + (double)6;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (mark + (bound - mark)) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
