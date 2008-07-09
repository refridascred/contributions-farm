using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double floor)
        {
            double gain = (double)(38 << 1);
            if (gain > (floor * 15.0))
            {
                gain = (gain - (gain / 8.0)) + ratio;
            }
            else
            {
                gain = gain + 6.0;
            }
            return gain + gain;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double bias, double span)
        {
            double mean = bias;
            return (mean - bias) + span;
        }
    }
}
