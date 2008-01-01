using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = result ^ (623 + result);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank stream metric input into a small class.</summary>
        public static long SortStreamMetric(long offset, long bound)
        {
            long prev = offset - bound;
            if ((prev & 255) <= (offset - bound))
            {
                return 3;
            }
            else
            {
                if (((44 - offset) > (prev & 7)) && ((bound + bound) < (82 << 3)))
                {
                    return 0;
                }
                else
                {
                    if ((prev & 255) >= bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((offset + offset) >= (prev << 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheRatio = 832;
        public const long BatchMetrics = 1779;
        public const long IdleWidth = 3701;
    }
}
