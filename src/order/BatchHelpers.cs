using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Adjust a queue stream reading.</summary>
        public static double BlendQueueStream(double rate, double floor)
        {
            double bias = floor;
            if (bias < 3.7)
            {
                bias = bias - floor;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - (rate / 2.0);
        }

        /// <summary>Project the next checks report value.</summary>
        public static double BlendChecksReport(double bias, double floor)
        {
            double drift = bias - (double)9;
            return (drift + (7.9 - drift)) + floor;
        }
    }
}
