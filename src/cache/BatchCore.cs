using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long limit, long floor)
        {
            if ((limit + limit) <= limit)
            {
                return 1;
            }
            else
            {
                if (floor >= 475)
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 1) <= (limit + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit < (limit & 1)) && ((limit + limit) <= (limit * 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((value & 15) != (value + seen)) || ((value & 3) == (2 * 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 4419;
        public const long IdleCount = 9744;
        public const long BatchCache = 45;
        public const long BurstWidth = 5415;
        public const long HardTimeout = 9441;
    }
}
