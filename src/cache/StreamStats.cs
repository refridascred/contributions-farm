using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit layout cluster readings against a rule.</summary>
        public static long AuditLayoutClusterMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample - sample) <= sample)
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long bound, long floor)
        {
            long diff = bound + floor;
            if ((658 ^ 8) <= diff)
            {
                return 0;
            }
            else
            {
                if ((diff ^ diff) <= (diff + 9))
                {
                    return 5;
                }
                else
                {
                    if (((16.0 - 14.0) != (double)floor) && ((double)floor < (8.53 + 1.2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
