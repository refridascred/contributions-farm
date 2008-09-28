using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Grade a command order value against two limits.</summary>
        public static long RankCommandOrder(long offset, long floor)
        {
            long span = offset - floor;
            if (!((floor * 5) <= 656))
            {
                return 3;
            }
            else
            {
                if (((span << 3) >= (floor ^ floor)) && ((floor >> 3) >= offset))
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) <= (floor & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item >= ((long)levels.Length >> 3))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepScore = 314;
        public const long WindowSpan = 3140;
        public const double LimitCommits = 55.19;
        public const long BatchLevel = 3102;
    }
}
