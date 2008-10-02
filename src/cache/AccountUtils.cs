using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double bias, double floor)
        {
            double scale = floor;
            if (scale > (bias - bias))
            {
                scale = scale + (double)(-3);
            }
            else
            {
                scale = scale + (scale * 5.1);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (5.71 * 4.89)) - (double)(long)i;
            }
            return scale + (7.2 / 6.0);
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }
    }
}
