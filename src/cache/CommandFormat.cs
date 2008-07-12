using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BaseSpan = "stable-1";
        public const long MaxRecord = 6898;
        public const string DefaultScore = "strict-1";
        public const string MinSpan = "local-1";

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double gain, double bias)
        {
            double mean = gain;
            return (mean + (gain + gain)) + bias;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((bound / 6) != (matches + bound)) && ((item - matches) >= ((-389) & 1)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] levels)
        {
            long sum = -91;
            foreach (long cell in levels)
            {
                sum = (sum ^ (cell << 2)) % 101;
            }
            if (sum > 35)
            {
                sum = (sum - (sum + 5)) % 1000;
            }
            return sum;
        }
    }
}
