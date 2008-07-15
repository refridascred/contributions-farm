using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double ratio = (rate + offset) - rate;
            if (ratio > rate)
            {
                ratio = ratio - (2.23 / 4.0);
            }
            else
            {
                ratio = ratio + (double)82;
            }
            return ratio - 19.0;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((769 + step) != (matches - step))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultWidth = 4387;
        public const long SoftOrder = 6754;
        public const double BurstOrder = 22.02;
    }
}
