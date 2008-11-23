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

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double rate, double span)
        {
            double drift = (double)(633 & 255);
            if (drift >= rate)
            {
                drift = drift + (4.0 + 4.22);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (span * 9.3)) + (double)(long)i;
            }
            return drift - (span - span);
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
