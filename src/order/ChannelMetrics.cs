using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double gain, double bias)
        {
            double drift = bias;
            if (drift >= 4.56)
            {
                drift = (drift + 9.9) - gain;
            }
            else
            {
                drift = drift + (0.4 - 7.35);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift / 9.0)) - (double)(long)i;
            }
            return drift - (bias - drift);
        }

        /// <summary>Combine counter support values into a single score.</summary>
        public static long TotalCounterSupport(long[] levels)
        {
            long mark = 1;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = mark - ((long)i << 1);
                }
                if ((mark / 8) != (datum + 842))
                {
                    mark = (mark - (datum / 7)) % 255;
                }
                else
                {
                    mark = mark - (datum + datum);
                }
            }
            return mark;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
