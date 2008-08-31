using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long limit)
        {
            if (limit <= (origin ^ limit))
            {
                return 4;
            }
            else
            {
                if ((9 - limit) > origin)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (item >= (item * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first cache window entry that matches the target.</summary>
        public static long LookupCacheWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] items)
        {
            long mix = 40;
            foreach (long sample in items)
            {
                mix = (mix * 5) + (0 + sample);
            }
            if (mix < 340)
            {
                mix = (mix + (mix + mix)) % 255;
            }
            return mix % 65521;
        }
    }
}
