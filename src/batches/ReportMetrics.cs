using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            New,
            Dropped,
            Draft,
            Pending,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] series)
        {
            long mark = 35;
            foreach (long cell in series)
            {
                mark = ((mark + (522 - mark)) % 65521) - cell;
                mark = (mark - mark) % 97;
            }
            return mark;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double ratio, double span)
        {
            double rate = 6.0;
            if (rate >= span)
            {
                rate = rate + (double)68;
            }
            else
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (span / 7.0);
        }
    }
}
