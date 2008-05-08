using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value >= hits)
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long seed, long seed2)
        {
            long next = seed - seed2;
            if ((4.44 / 4.0) >= (double)seed2)
            {
                return 4;
            }
            else
            {
                if ((double)seed2 != (double)next)
                {
                    return 0;
                }
                else
                {
                    if ((double)seed2 <= 6.63)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.0 * 7.6) >= (double)next)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
