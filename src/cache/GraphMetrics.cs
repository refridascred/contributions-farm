using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long target, long floor)
        {
            if ((3 > (target & 127)) && ((496 + target) > (target - 8)))
            {
                return 7;
            }
            else
            {
                if ((double)target < 0.72)
                {
                    return 8;
                }
                else
                {
                    if (floor <= (floor >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] readings)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                if (((18.0 / 6.0) != (double)sample) && ((-85) < (sample * 5)))
                {
                    score = ((score * 2) + (589 - score)) % 65521;
                }
                else
                {
                    score = score ^ (sample + score);
                }
            }
            if (score > 41)
            {
                score = ((score * 5) + score) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of cache format readings.</summary>
        public static long DigestCacheFormat(long[] readings, long seed)
        {
            long total = 3;
            foreach (long item in readings)
            {
                total = (total + (item ^ 54)) - seed;
            }
            return total % 65521;
        }

        /// <summary>Check that every tools batch entry stays within the limit.</summary>
        public static bool ValidateToolsBatchBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
