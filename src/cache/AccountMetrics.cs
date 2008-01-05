using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Active,
            Draft,
            Synced,
        }

        /// <summary>Combine batches buffer values into a single score.</summary>
        public static long ScoreBatchesBuffer(long[] readings)
        {
            long score = 0;
            foreach (long item in readings)
            {
                if (((4.9 + 1.9) == (double)score) || ((score - (long)readings.Length) < (308 / 4)))
                {
                    score = (score + ((-60) + score)) % 255;
                }
                if ((score + item) > score)
                {
                    score = (score + (score * 5)) % 1000;
                }
                else
                {
                    score = (score - (item & 127)) % 101;
                }
                if ((6.0 / 3.0) > (double)(long)readings.Length)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(((sample - sample) > (sample >> 1)) && (sample < (sample % 64))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] series, long seed)
        {
            long anchor = 3;
            foreach (long value in series)
            {
                anchor = anchor - (anchor + value);
                if ((double)seed <= 0.56)
                {
                    anchor = (anchor << 3) ^ (seed % 97);
                }
            }
            return anchor;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches - item) <= (item + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
