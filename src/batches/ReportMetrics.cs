using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double rate, double offset)
        {
            double load = rate;
            if (load > (offset + load))
            {
                load = load - (offset - rate);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + rate) - (double)(long)i;
            }
            return load + (rate + rate);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "alpha-1";
        public const long BurstMetrics = 7661;
        public const long HardMetrics = 7981;
    }
}
