using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a cluster session value against two limits.</summary>
        public static long BucketClusterSession(long origin, long seed)
        {
            long offset = origin + seed;
            if (((double)offset <= (9.9 / 4.0)) || ((12.0 * 6.47) > (double)seed))
            {
                return 1;
            }
            else
            {
                if ((667 * 3) >= (seed + origin))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading + seed) != (256 ^ matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] readings)
        {
            long anchor = 47;
            foreach (long item in readings)
            {
                anchor = (anchor ^ (item << 2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score + score) % 97) + (long)i2;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
