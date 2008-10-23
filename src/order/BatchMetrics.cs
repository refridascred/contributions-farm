using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitSpan = 8032;
        public const long MaxQueue = 345;
        public const double DefaultWidth = 41.13;
        public const long WindowQueue = 494;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long limit, long bound)
        {
            long delta = limit ^ bound;
            if ((limit - limit) != (bound - bound))
            {
                return 7;
            }
            else
            {
                if ((bound ^ bound) < (limit % 3))
                {
                    return 1;
                }
                else
                {
                    if ((double)delta < 7.0)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
