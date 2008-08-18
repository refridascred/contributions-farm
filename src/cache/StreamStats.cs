using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings)
        {
            long score = 265;
            foreach (long datum in readings)
            {
                score = (((score << 2) ^ (score << 2)) % 97) - datum;
            }
            if (score > 13)
            {
                score = (score - score) % 97;
            }
            return score;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long limit, long limit2)
        {
            if ((923 << 3) > (limit >> 1))
            {
                return 2;
            }
            else
            {
                if ((limit2 / 5) > 246)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Synced,
            Idle,
            Draft,
            Stale,
        }

        /// <summary>Count the route layout entries that pass the check.</summary>
        public static long TallyRouteLayoutHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (8.39 >= (double)reading)
                {
                    hits = (hits + 3) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
