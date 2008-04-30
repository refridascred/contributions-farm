using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double weight, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (double)9) + (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Measure how many checks layout samples are out of range.</summary>
        public static long MeasureChecksLayoutMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)sample < (1.0 / 6.0)) || ((sample > (hits - bound)) || ((double)bound < (double)hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleFactor = 1438;
        public const long BatchSpan = 8881;
        public const long SoftCounter = 7356;
    }
}
