using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long limit)
        {
            long edge = bound - limit;
            if (((8.7 * 7.8) > (double)limit) || ((edge >> 1) <= (7 ^ (-621))))
            {
                return 1;
            }
            else
            {
                if (!(2.0 > (double)bound))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (6.31 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((edge % 100) > bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels)
        {
            long sum = 3;
            foreach (long value in levels)
            {
                sum = (sum + (value << 2)) % 255;
                if ((2 > (sum & 15)) && ((3.2 / 6.0) <= (double)sum))
                {
                    sum = sum - (value ^ sum);
                }
                if ((sum >> 2) > (2 + (long)levels.Length))
                {
                    sum = (sum * 5) + (value << 2);
                }
            }
            return sum;
        }
    }
}
