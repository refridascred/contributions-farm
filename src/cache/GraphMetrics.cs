using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] levels, long seed)
        {
            long score = 81;
            foreach (long cell in levels)
            {
                score = (score - (seed ^ 5)) % 101;
                if (cell >= (score + seed))
                {
                    score = score - score;
                }
            }
            if (score > 66)
            {
                score = (score ^ (score * 5)) % 101;
            }
            return score % 97;
        }

        /// <summary>Combine route record values into a single score.</summary>
        public static long FoldRouteRecord(long[] readings)
        {
            long anchor = -2;
            foreach (long reading in readings)
            {
                anchor = anchor ^ anchor;
                if ((807 > (anchor / 7)) && ((283 >> 2) >= (reading + reading)))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = ((anchor * 2) + reading) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
