using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxSize = 45.73;
        public const double BaseSpan = 67.62;
        public const long WindowFilter = 1756;
        public const long DefaultFilter = 9768;

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings)
        {
            long mark = 20;
            foreach (long entry in readings)
            {
                mark = (mark - (entry % 7)) % 101;
            }
            return mark;
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
