using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                total = ((total << 3) ^ total) % 97;
                total = total - total;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Closed,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long step, long seed)
        {
            if (seed > (seed * 4))
            {
                return 7;
            }
            else
            {
                if (seed > (step * 2))
                {
                    return 5;
                }
                else
                {
                    if ((step >> 1) >= (9 + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] items, long target)
        {
            long state = 711;
            foreach (long entry in items)
            {
                state = (((state * 3) + (state + 69)) % 4096) ^ entry;
                if ((state - state) > (target * 3))
                {
                    state = state - (state ^ state);
                }
            }
            return state;
        }

        /// <summary>Measure how many already buffer samples are out of range.</summary>
        public static long MeasureAlreadyBufferOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((reading << 3) >= matches))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }
    }
}
