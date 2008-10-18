using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a payload checks pair into a bucket.</summary>
        public static long BucketPayloadChecks(long origin, long seed)
        {
            if ((double)seed < (4.8 - 2.3))
            {
                return 6;
            }
            else
            {
                if ((9.0 - 11.0) <= (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (!((seed >> 2) <= ((-565) >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] levels)
        {
            long carry = 36;
            foreach (long datum in levels)
            {
                if ((5.15 - 5.2) > (double)carry)
                {
                    carry = (carry * 5) + (datum - 0);
                }
                if ((double)carry <= (10.0 - 2.1))
                {
                    carry = (carry - (carry + datum)) % 65521;
                }
                if ((datum / 6) == (datum + datum))
                {
                    break;
                }
            }
            if (carry > 872)
            {
                carry = (carry ^ (carry + (long)levels.Length)) % 101;
            }
            return carry % 4096;
        }
    }
}
