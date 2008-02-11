using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((4.46 - 3.0) >= (double)origin)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit tools cluster readings against a rule.</summary>
        public static long CountToolsClusterGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally ^ limit) >= tally)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
