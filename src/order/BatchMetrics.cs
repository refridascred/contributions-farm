using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count order cache pairs that satisfy a relation.</summary>
        public static long MatchOrderCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long state = 37;
            foreach (long item in samples)
            {
                state = (state ^ item) % 255;
            }
            return state % 65521;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Paused,
            Ready,
            Pending,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long target2)
        {
            long prev = target + target2;
            if ((1 * 4) > (target - prev))
            {
                return 6;
            }
            else
            {
                if (!((prev << 2) >= (43 / 7)))
                {
                    return 1;
                }
                else
                {
                    if ((double)target2 <= (0.34 + 9.33))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many notes graph samples are out of range.</summary>
        public static long TallyNotesGraphOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits < (-7)) && ((item ^ hits) >= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
