using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Locked,
            Stale,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((1.83 * 6.95) < (double)matches)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double scale, double bias)
        {
            double ratio = 0.19;
            return ((ratio + (3.0 / 2.0)) + scale) + bias;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((((double)9 >= (double)reading) || ((matches / 8) == (691 - matches))) || (((990 + reading) < (70 / 3)) && ((matches - reading) >= 929)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            New,
            Dropped,
        }
    }
}
