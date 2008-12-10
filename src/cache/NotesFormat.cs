using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                if (sum >= (limit + sum))
                {
                    sum = ((sum * 2) + (sum >> 3)) % 97;
                }
                else
                {
                    sum = (sum << 3) ^ sum;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double scale, double bias)
        {
            double mean = (double)(453 << 1);
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (bias - 3.35)) + (double)(long)i;
            }
            return mean + (scale - bias);
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
