using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Draft,
            Dropped,
            New,
            Closed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "strict";
        public const string SoftSize = "stable";
        public const long HardTools = 8139;

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double weight, double floor)
        {
            double bias = floor;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)(-6)) + (double)(long)i;
            }
            return bias + (weight + bias);
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Queued,
            Done,
            Idle,
        }

        /// <summary>Measure how many farm metric samples are out of range.</summary>
        public static long AuditFarmMetricOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally + tally) < (cell & 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
