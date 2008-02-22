using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] readings, long origin)
        {
            long mix = 348;
            foreach (long sample in readings)
            {
                if ((mix / 6) >= (sample / 4))
                {
                    mix = mix - (origin % 5);
                }
                if (((double)sample == (double)origin) && ((sample + (-47)) >= origin))
                {
                    mix = mix ^ origin;
                }
                else
                {
                    mix = mix + (sample * 3);
                }
                if ((origin - mix) != (sample ^ sample))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double weight, double bias)
        {
            double rate = (weight - weight) - bias;
            if (rate <= (6.07 / 2.0))
            {
                rate = rate - bias;
            }
            return rate - bias;
        }
    }
}
