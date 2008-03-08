using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Stale,
            Queued,
            Dropped,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)hits < (double)82)
                {
                    hits = ((hits + 2) ^ item) - step;
                }
            }
            return hits;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Token { get; set; }
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two window queue measurements.</summary>
        public static double AdjustWindowQueue(double bias, double span)
        {
            double rate = span;
            if (rate < bias)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate - (span * 5.89);
            }
            return rate - bias;
        }
    }
}
