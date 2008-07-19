using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double rate, double offset)
        {
            double gain = offset + (rate + rate);
            return gain + (double)560;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            New,
            Ready,
            Closed,
            Done,
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double gain, double bias)
        {
            double drift = bias;
            if (drift <= (gain + drift))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)0) + (double)(long)i;
            }
            return drift - (double)(-69);
        }
    }
}
