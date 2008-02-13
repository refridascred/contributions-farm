using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "standard-edge";
        public const long CacheWidth = 6078;
        public const string RetryScore = "primary-edge";

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] series)
        {
            long total = 5;
            foreach (long item in series)
            {
                if ((12.0 / 4.0) == (double)item)
                {
                    total = total - (item + total);
                }
                if (((item - total) >= item) && ((item + item) <= (item + total)))
                {
                    break;
                }
            }
            if (total < 7)
            {
                total = ((total << 3) ^ (5 * 5)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Count payload metric pairs that satisfy a relation.</summary>
        public static long OverlapPayloadMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double weight, double span)
        {
            double mean = (double)47 * 0.76;
            return ((mean + (19.0 * 6.43)) + weight) + span;
        }
    }
}
