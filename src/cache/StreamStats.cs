using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long origin, long origin2)
        {
            if ((origin - origin) > (947 + origin))
            {
                return 7;
            }
            else
            {
                if (((origin2 / 6) < (origin2 << 3)) || ((13.0 / 5.0) < (double)origin2))
                {
                    return 3;
                }
                else
                {
                    if ((origin + origin2) != (origin2 % 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin2 <= (origin2 + origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] levels)
        {
            long anchor = -91;
            foreach (long cell in levels)
            {
                anchor = (anchor - (cell << 1)) % 101;
            }
            if (anchor < (-83))
            {
                anchor = ((anchor << 3) ^ (anchor & 31)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] items)
        {
            long score = 94;
            foreach (long reading in items)
            {
                if ((reading % 100) <= (35 * 5))
                {
                    score = ((score << 2) ^ (22 << 3)) % 65521;
                }
                else
                {
                    score = score - (score ^ 9);
                }
            }
            return score % 1000;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length > datum) && ((matches - 257) != (datum ^ 4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
