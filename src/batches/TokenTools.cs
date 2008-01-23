using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a contributi filter pair into a bucket.</summary>
        public static long BucketContributiFilter(long limit, long origin)
        {
            if ((99 - origin) <= (limit ^ limit))
            {
                return 5;
            }
            else
            {
                if (!((802 - 1) > (limit / 8)))
                {
                    return 8;
                }
                else
                {
                    if (limit >= (origin - limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
