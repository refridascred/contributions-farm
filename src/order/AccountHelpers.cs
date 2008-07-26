using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchInterval = 7501;
        public const string HardLayout = "local-1";
        public const double MaxBudget = 42.89;

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double scale, double span)
        {
            double drift = 3.8;
            if (drift < (9.33 + span))
            {
                drift = drift + (double)48;
            }
            else
            {
                drift = drift + (scale + span);
            }
            return drift - (double)965;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((datum << 1) != (datum - datum)) || !(datum >= (7 - datum)))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public double Offset { get; set; }
        }
    }
}
