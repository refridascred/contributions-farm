using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next session order value from a seed.</summary>
        public static long RollSessionOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample % 7) <= (count << 1)) || (count > (count << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double bias, double span)
        {
            double scale = (span / 5.0) / 7.0;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + span) + (double)(long)i) - bias;
            }
            return scale + (span / 7.0);
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
