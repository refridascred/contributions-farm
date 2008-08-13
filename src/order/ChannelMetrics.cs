using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((tally << 3) == (tally / 3)) && (step > tally))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftScore = "local";
        public const long IdleBudget = 1770;
        public const long BatchFactor = 3227;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (sample <= (seen + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
