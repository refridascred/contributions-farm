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

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (((limit & 15) > (-75)) || ((state - state) != ((long)i / 8)))
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
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
