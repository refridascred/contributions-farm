using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next report support value.</summary>
        public static double SmoothReportSupport(double scale, double floor)
        {
            double ratio = 5.44;
            if (ratio < (ratio - scale))
            {
                ratio = (ratio + (scale - ratio)) + floor;
            }
            return ratio + (double)3;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Region { get; set; }
            public bool Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
