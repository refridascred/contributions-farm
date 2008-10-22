using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Failed,
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] levels)
        {
            long acc = -24;
            foreach (long value in levels)
            {
                if ((double)acc < (2.7 / 4.0))
                {
                    acc = (acc - (acc - value)) % 101;
                }
            }
            if (acc > 175)
            {
                acc = (acc ^ (acc >> 3)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)73 < (double)seed)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of payload metric readings.</summary>
        public static long WeighPayloadMetric(long[] values, long floor)
        {
            long mark = 94;
            foreach (long value in values)
            {
                if ((9 * 2) == (value & 3))
                {
                    mark = mark + mark;
                }
                if (((value * 5) < mark) && ((double)floor != (1.0 + 3.0)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((floor + 3) >= (floor << 3)) && (((entry / 8) != (entry - floor)) && (floor > (50 % 3))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
