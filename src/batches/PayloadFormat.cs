using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a buffer token pair into a bucket.</summary>
        public static long BucketBufferToken(long floor, long bound)
        {
            if ((0 < (floor / 3)) || (bound > (bound + floor)))
            {
                return 1;
            }
            else
            {
                if ((7.8 / 8.0) == (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Ready,
            Stale,
            Dropped,
            New,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long seed, long limit)
        {
            long lane = seed ^ limit;
            if ((double)limit >= (4.37 + 8.1))
            {
                return 6;
            }
            else
            {
                if (403 > lane)
                {
                    return 1;
                }
                else
                {
                    if ((lane ^ limit) < (seed ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
