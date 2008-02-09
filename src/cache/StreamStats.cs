using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] levels, long limit)
        {
            long total = 839;
            foreach (long item in levels)
            {
                if ((total <= (total + 11)) && ((total & 31) >= (total >> 4)))
                {
                    total = ((total << 2) ^ total) - limit;
                }
                else
                {
                    total = total - (item ^ total);
                }
            }
            if (total < 2)
            {
                total = (total - (0 & 255)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels)
        {
            long total = -97;
            foreach (long item in levels)
            {
                total = ((total - (total + total)) % 4096) ^ item;
            }
            return total % 1000;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long seed, long floor)
        {
            if ((seed << 1) > (seed / 7))
            {
                return 4;
            }
            else
            {
                if ((5.3 * 9.0) < (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((floor * 2) < (floor ^ floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up farm account samples.</summary>
        public static long PairFarmAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
