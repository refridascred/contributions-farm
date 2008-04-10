using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum >> 3) < hits)
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stats payload series from a seed.</summary>
        public static long RollStatsPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = mix ^ mix;
                mix = (mix ^ bound) % 65521;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long bound)
        {
            if (offset > (48 - offset))
            {
                return 4;
            }
            else
            {
                if ((offset / 4) < (offset & 1))
                {
                    return 5;
                }
                else
                {
                    if (!((offset + offset) < (517 + 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound << 2) != (offset - offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the payload window series from a seed.</summary>
        public static long RollPayloadWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum ^ (limit + sum)) % 97;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
