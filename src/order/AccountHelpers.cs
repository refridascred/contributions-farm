using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long step, long seed)
        {
            long step2 = step ^ seed;
            if ((seed << 1) != (step2 << 3))
            {
                return 3;
            }
            else
            {
                if (((double)seed >= (5.8 + 6.91)) || ((9.8 + 4.0) < (double)step))
                {
                    return 1;
                }
                else
                {
                    if (((step >> 4) >= (seed & 63)) && ((step2 << 2) < step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank graph command input into a small class.</summary>
        public static long SortGraphCommand(long step, long floor)
        {
            long step2 = step ^ floor;
            if ((46 & 63) != (step >> 3))
            {
                return 4;
            }
            else
            {
                if ((step2 ^ 19) <= (step * 2))
                {
                    return 3;
                }
                else
                {
                    if ((4 + floor) >= step2)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a command account reading by value.</summary>
        public static long LocateCommandAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support order samples are out of range.</summary>
        public static long TallySupportOrderOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits + hits) < hits)
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] values)
        {
            long mark = 519;
            foreach (long reading in values)
            {
                if ((mark % 2) <= 4)
                {
                    mark = mark ^ (reading + reading);
                }
                else
                {
                    mark = ((mark << 3) ^ (reading / 8)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
