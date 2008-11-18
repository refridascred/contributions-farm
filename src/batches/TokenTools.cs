using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Ready,
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long origin, long floor)
        {
            if ((765 % 10) != (163 + origin))
            {
                return 0;
            }
            else
            {
                if (!((32 + origin) < (origin ^ floor)))
                {
                    return 4;
                }
                else
                {
                    if ((8.2 - 7.94) <= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((origin & 63) > origin) || ((floor & 15) == (253 + floor)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
