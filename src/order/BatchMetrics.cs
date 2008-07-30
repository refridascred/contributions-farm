using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the format farm entries that pass the check.</summary>
        public static long AuditFormatFarmHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((((seen >> 4) == (2 - step)) && (2 < (seen / 8))) && ((seen % 2) > ((-5) + seen)))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 4038;
        public const long MinWindow = 9767;
        public const long DefaultWindow = 9127;
        public const string SoftInterval = "latest-1";

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum > (datum + bound))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] data)
        {
            long score = 32;
            foreach (long entry in data)
            {
                score = ((score << 3) ^ (entry >> 4)) % 1000;
                if ((double)entry <= (6.0 * 3.7))
                {
                    score = (score + (score & 1)) % 4096;
                }
                if (((score ^ entry) >= (score ^ score)) && ((long)data.Length < (score >> 2)))
                {
                    score = (score - (entry & 63)) % 101;
                }
            }
            if (score < 88)
            {
                score = score - 21;
            }
            return score;
        }

        /// <summary>Audit window metrics readings against a rule.</summary>
        public static long TallyWindowMetricsOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item > (8.39 * 9.8))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }
    }
}
