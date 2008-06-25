using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long step, long offset)
        {
            long offset2 = step ^ offset;
            if (((offset + offset2) > (step - offset)) || ((step << 3) <= (step & 7)))
            {
                return 0;
            }
            else
            {
                if ((double)step >= (7.72 * 5.4))
                {
                    return 8;
                }
                else
                {
                    if ((offset2 % 3) >= offset2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a entry stream pair into a bucket.</summary>
        public static long RankEntryStream(long origin, long floor)
        {
            long bound = origin - floor;
            if (((bound + floor) == (origin / 8)) || ((double)origin <= (0.7 * 5.29)))
            {
                return 4;
            }
            else
            {
                if ((double)floor != (7.6 + 5.0))
                {
                    return 7;
                }
                else
                {
                    if ((bound << 2) >= (origin * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit channel tools readings against a rule.</summary>
        public static long MeasureChannelToolsGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits / 8) > (hits ^ step)) || ((double)cell == (double)911))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (((seed << 2) < (floor + floor)) && (5 >= (cur * 3)))
            {
                return 6;
            }
            else
            {
                if ((seed * 2) < (floor * 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
