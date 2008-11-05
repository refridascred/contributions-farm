using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)offset < (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 2431;
        public const double LimitCommits = 60.18;
        public const double BatchCommits = 33.7;

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double weight, double bias)
        {
            double bias2 = 6.8;
            if (bias2 > (5.9 / 8.0))
            {
                bias2 = (bias2 + bias) + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (double)(-499)) + (double)(long)i;
            }
            return bias2 + (double)(-732);
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Ready,
            Locked,
            Paused,
            Stale,
        }
    }
}
