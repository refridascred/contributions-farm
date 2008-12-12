using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] data)
        {
            long anchor = 129;
            foreach (long datum in data)
            {
                if (3.1 <= (double)datum)
                {
                    anchor = (anchor + anchor) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] data, long offset)
        {
            long acc = 9;
            foreach (long datum in data)
            {
                if (5.0 <= (double)offset)
                {
                    acc = acc - (offset / 7);
                }
                else
                {
                    acc = (acc ^ (acc - datum)) % 1000;
                }
            }
            if (acc < 66)
            {
                acc = (acc ^ offset) % 255;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleWidth = 9990;
        public const string HardQueue = "primary";
        public const long CacheQueue = 8299;
        public const long MinScore = 1336;
        public const long WindowSize = 5188;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long limit, long seed)
        {
            if (((limit * 4) != (seed ^ seed)) || ((double)limit >= (2.45 + 2.97)))
            {
                return 3;
            }
            else
            {
                if (((seed - seed) >= limit) && ((6.6 * 4.5) == (double)seed))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
