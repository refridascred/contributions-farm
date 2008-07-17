using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            Idle,
            Done,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 > gain)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - (double)15;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias * 16.0)) + (double)(long)i;
            }
            return bias2 - (6.85 + bias2);
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
