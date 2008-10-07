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

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double rate = (bias - scale) + (8.54 / 2.0);
            if (rate >= (scale - bias))
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate + (double)48;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)2) + (double)(long)i;
            }
            return rate + (5.1 - rate);
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
