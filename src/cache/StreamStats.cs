using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((8.55 + 6.97) == (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Token { get; set; }
            public double Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = (result ^ (418 * 3)) % 101;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double scale, double span)
        {
            double mean = scale;
            return (mean + (mean / 7.0)) + span;
        }
    }
}
