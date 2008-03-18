using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double bias, double span)
        {
            double drift = (double)(69 - 932);
            return (drift - (bias + 7.44)) + span;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
