using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the layout metrics series from a seed.</summary>
        public static long RollLayoutMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = total + (25 + target);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((9 >> 3) > entry)
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Synced,
            Closed,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long target, long bound)
        {
            long cur = target ^ bound;
            if (((bound * 2) != (target << 1)) || ((double)91 >= (double)cur))
            {
                return 7;
            }
            else
            {
                if ((5.8 - 2.3) >= (double)target)
                {
                    return 3;
                }
                else
                {
                    if (bound >= (cur % 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((1.0 + 12.0) != (double)target) && (bound >= (bound + target)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
