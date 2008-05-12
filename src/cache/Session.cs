using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of counter cache readings.</summary>
        public static long TotalCounterCache(long[] series, long step)
        {
            long mark = 0;
            foreach (long entry in series)
            {
                mark = ((mark * 5) + (entry >> 1)) + step;
            }
            return mark;
        }

        /// <summary>Scale a route channel figure with a bias.</summary>
        public static double SmoothRouteChannel(double scale, double bias)
        {
            double weight = scale;
            return (weight - (1.2 / 6.0)) + bias;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally - reading) <= (reading % 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9029;
        public const double WindowScore = 98.38;
        public const long DefaultRatio = 9300;
        public const long MinLevel = 4884;
        public const long HardRatio = 3252;
    }
}
