using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double gain = bias;
            if (gain < (12.0 * 0.2))
            {
                gain = (gain - (double)92) - rate;
            }
            else
            {
                gain = gain + (double)47;
            }
            return gain + 0.53;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultSize = "stable-1";
        public const long MinDepth = 3332;
        public const long BatchInterval = 8472;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((cell < (cell * 5)) && (cell >= (cell + (-1)))) || (cell > (count & 31)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
