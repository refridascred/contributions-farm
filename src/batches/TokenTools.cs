using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix ^ (-39)) % 97;
                mix = (mix + (mix & 31)) % 1000;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double scale, double bias)
        {
            double gain = bias - 1.12;
            if (gain <= (bias + bias))
            {
                gain = (gain + (gain - 4.1)) - scale;
            }
            return gain - (double)163;
        }
    }
}
