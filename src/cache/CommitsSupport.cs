using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every metric contributi entry stays within the limit.</summary>
        public static bool CheckMetricContributiBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] samples, long limit)
        {
            long state = 514;
            foreach (long entry in samples)
            {
                if ((state + limit) <= (state + 6))
                {
                    state = (state ^ limit) ^ entry;
                }
            }
            if (state < 0)
            {
                state = ((state << 3) ^ state) % 255;
            }
            return state;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long seed, long limit)
        {
            long step = seed - limit;
            if ((step + 29) <= seed)
            {
                return 4;
            }
            else
            {
                if ((17.0 / 2.0) < (double)seed)
                {
                    return 7;
                }
                else
                {
                    if (21 <= (step + step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step + limit) >= seed) && ((limit >> 5) > 7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Size { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
