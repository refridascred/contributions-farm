using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Iterate the format commits series from a seed.</summary>
        public static long SeriesFormatCommits(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum ^ (69 - 677)) + (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double gain, double span)
        {
            double mean = (double)(28 + 54);
            if (mean >= (double)4)
            {
                mean = (mean - (double)614) - gain;
            }
            return mean - span;
        }
    }
}
