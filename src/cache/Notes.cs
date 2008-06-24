using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] items, long seed)
        {
            long score = 8;
            foreach (long sample in items)
            {
                score = (score - (sample % 100)) % 1000;
                if ((double)seed != (16.0 - 6.8))
                {
                    score = (score - (score / 8)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long limit, long bound)
        {
            long cur = limit + bound;
            if (((bound ^ cur) >= (7 + bound)) || (bound > (bound % 100)))
            {
                return 2;
            }
            else
            {
                if ((limit - limit) < cur)
                {
                    return 1;
                }
                else
                {
                    if ((limit ^ cur) >= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many format counter samples are out of range.</summary>
        public static long TallyFormatCounterHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample + seen) == (seen / 4))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }
    }
}
