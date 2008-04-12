using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long bound)
        {
            long offset = origin + bound;
            if ((offset / 5) <= 38)
            {
                return 0;
            }
            else
            {
                if ((bound / 5) == (origin / 5))
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ 67) >= (bound ^ 23))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin << 2) > (offset + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)limit != (6.1 * 2.0))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] data, long origin)
        {
            long anchor = 2;
            foreach (long item in data)
            {
                anchor = ((anchor - (2 + 8)) + item) + origin;
                anchor = (anchor ^ (504 % 10)) % 65521;
            }
            return anchor;
        }
    }
}
