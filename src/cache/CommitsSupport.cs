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

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long result = 6;
            foreach (long value in levels)
            {
                result = ((result - (result + 56)) % 65521) + value;
                result = (result << 2) ^ (result << 1);
            }
            return result;
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

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchLevel = 914;
        public const long BurstMetric = 50;
        public const double WindowLevel = 28.71;
        public const long IdleSize = 5011;

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
