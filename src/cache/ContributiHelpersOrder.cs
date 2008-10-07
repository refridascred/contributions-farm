using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next stream session value.</summary>
        public static double AdjustStreamSession(double gain, double span)
        {
            double gain2 = 1.53;
            if (gain2 >= (18.0 / 9.0))
            {
                gain2 = gain2 - (gain - span);
            }
            return gain2 + span;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
