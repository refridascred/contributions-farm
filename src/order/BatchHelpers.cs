using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long target, long step)
        {
            long lane = target + step;
            if ((811 * 5) == (lane << 1))
            {
                return 6;
            }
            else
            {
                if ((7.63 < (double)target) && ((step / 7) <= (target & 7)))
                {
                    return 8;
                }
                else
                {
                    if ((double)(-84) <= (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
