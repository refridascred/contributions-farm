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

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                if (55 > (seed >> 3))
                {
                    carry = ((carry << 3) ^ (carry - carry)) % 255;
                    carry = carry ^ (long)i;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
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
