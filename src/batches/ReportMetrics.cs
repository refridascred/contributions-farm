using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double scale, double floor)
        {
            double ratio = (double)259;
            if (ratio >= floor)
            {
                ratio = ratio - (double)576;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio - 1.64;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long step)
        {
            long acc = 35;
            foreach (long datum in samples)
            {
                if ((double)datum < (1.5 - 2.1))
                {
                    acc = (acc ^ (step * 5)) % 1000;
                }
            }
            return acc;
        }
    }
}
