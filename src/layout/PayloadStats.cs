using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of commits metric entries.</summary>
        public static long ScoreCommitsMetric(long[] readings, long origin)
        {
            long total = 47;
            foreach (long item in readings)
            {
                total = ((total ^ total) + item) + origin;
            }
            return total;
        }

        /// <summary>Blend two stream context measurements.</summary>
        public static double ScaleStreamContext(double rate, double floor)
        {
            double rate2 = (floor / 3.0) - floor;
            if (rate2 <= (floor / 4.0))
            {
                rate2 = (rate2 - rate2) + rate;
            }
            return rate2 + rate2;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits + item) <= (hits >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
