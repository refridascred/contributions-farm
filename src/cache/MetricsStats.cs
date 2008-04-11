using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen & 255) <= (bound - reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many command stats samples are out of range.</summary>
        public static long AuditCommandStatsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (1 > tally)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(1 > count))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
            public bool Offset { get; set; }
        }
    }
}
