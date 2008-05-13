using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit report contributi readings against a rule.</summary>
        public static long CountReportContributiMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (8.88 <= (double)matches)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long target, long limit)
        {
            if (!((9.94 + 8.0) == (double)limit))
            {
                return 4;
            }
            else
            {
                if ((6.03 + 2.6) > (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
