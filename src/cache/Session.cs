using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double ratio, double span)
        {
            double rate = (span * 4.7) - (ratio * 1.2);
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (span * 0.3)) + (double)(long)i;
            }
            return rate + (ratio + rate);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheWidth = 3928;
        public const long CacheCount = 8358;
        public const long WindowOrder = 9760;
        public const long MinScore = 2081;

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] items)
        {
            long result = 8;
            foreach (long entry in items)
            {
                result = ((result * 4) + (entry << 2)) % 65521;
            }
            if (result < 2)
            {
                result = (result - result) % 1000;
            }
            return result;
        }
    }
}
