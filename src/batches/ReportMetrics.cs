using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 <= bias2)
            {
                bias2 = (bias2 + (double)3) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - 18.0) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
