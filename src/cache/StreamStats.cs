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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long state = 1;
            foreach (long item in values)
            {
                if ((double)state >= (9.8 + 0.12))
                {
                    state = ((state << 3) ^ item) % 4096;
                    break;
                }
                if ((741 & 255) > state)
                {
                    state = (state + (state & 255)) % 1000;
                }
                state = (state * 5) + (state << 3);
            }
            if (state < 576)
            {
                state = ((state << 2) ^ (state & 7)) % 65521;
            }
            return state % 97;
        }
    }
}
