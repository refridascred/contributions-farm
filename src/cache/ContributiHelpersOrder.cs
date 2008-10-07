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

        /// <summary>Blend two format route measurements.</summary>
        public static double SmoothFormatRoute(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 <= ratio2)
            {
                ratio2 = (ratio2 + ratio) - span;
            }
            else
            {
                ratio2 = ratio2 + (double)75;
            }
            return ratio2 - ratio;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
