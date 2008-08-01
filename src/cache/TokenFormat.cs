using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long origin, long limit)
        {
            if (((origin % 7) >= (origin & 31)) && (limit >= (limit & 1)))
            {
                return 3;
            }
            else
            {
                if (limit <= (limit & 127))
                {
                    return 1;
                }
                else
                {
                    if (limit < (limit + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit <= (origin - limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)item >= (3.6 / 4.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
