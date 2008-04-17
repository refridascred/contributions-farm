using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double ratio, double span)
        {
            double gain = (ratio / 9.0) * 1.4;
            if (gain <= gain)
            {
                gain = gain + (double)2;
            }
            else
            {
                gain = gain - ratio;
            }
            return gain - (span / 2.0);
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double floor)
        {
            double rate = floor;
            if (rate <= (double)613)
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (rate * 0.32)) + (double)(long)i;
            }
            return rate + (scale + scale);
        }
    }
}
