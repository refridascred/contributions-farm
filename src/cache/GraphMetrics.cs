using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Synced,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxWidth = 1086;
        public const double StepFormat = 81.4;
        public const long HardFormat = 243;
        public const long BaseFormat = 3819;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double rate, double floor)
        {
            double rate2 = (double)(8 - 860);
            if (rate2 < (floor - rate))
            {
                rate2 = rate2 + (floor + floor);
            }
            else
            {
                rate2 = rate2 - (rate - rate);
            }
            return rate2 + rate2;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 1531;
        public const long MaxEntry = 9022;
        public const long BaseEntry = 4185;
    }
}
