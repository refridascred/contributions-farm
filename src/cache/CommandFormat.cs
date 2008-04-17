using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double ratio, double floor)
        {
            double scale = (double)((-993) * 4);
            if (scale <= (floor - 20.0))
            {
                scale = scale + (ratio - scale);
            }
            return scale + (ratio * 5.6);
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double rate, double bias)
        {
            double load = (rate - bias) - (rate + rate);
            if (load <= (load + 6.7))
            {
                load = load + bias;
            }
            return load - (load * 9.2);
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long origin)
        {
            if (4.2 <= (double)origin)
            {
                return 2;
            }
            else
            {
                if ((seed - 348) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((origin - seed) > (seed ^ origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Size { get; set; } = "";
            public double Weight { get; set; }
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
