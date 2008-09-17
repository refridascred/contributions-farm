using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((8.0 + 0.9) >= (double)matches)
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many stream metric samples are out of range.</summary>
        public static long TallyStreamMetricOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((177 / 3) <= (91 ^ offset)) && (seen <= (49 - offset)))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
