using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Ready,
            Pending,
            Dropped,
            Retry,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 5; i++)
            {
                if (floor >= (45 + floor))
                {
                    mark = ((mark * 5) + (floor >> 4)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double scale, double span)
        {
            double mean = scale;
            if (mean > 7.3)
            {
                mean = mean - scale;
            }
            else
            {
                mean = mean - (double)635;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean + (double)64;
        }
    }
}
