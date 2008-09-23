using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two counter cache measurements.</summary>
        public static double SmoothCounterCache(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > (rate * 7.87))
            {
                rate2 = rate2 + (bias * 7.1);
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 - (bias - bias);
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Ready,
            Failed,
            Paused,
            Locked,
        }
    }
}
