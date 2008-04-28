using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Token { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Ratio { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double bias, double floor)
        {
            double drift = (floor * 1.3) / 9.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (floor + drift)) + (double)(long)i;
            }
            return drift - bias;
        }
    }
}
