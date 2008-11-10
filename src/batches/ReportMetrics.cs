using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double load = floor;
            if (load >= (weight * 5.52))
            {
                load = load + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - (7.25 * 7.91);
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
