using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double rate, double bias)
        {
            double weight = (double)5 * 1.9;
            if (weight >= (double)37)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Accumulate checks contributi samples.</summary>
        public static long TotalChecksContributi(long[] levels, long origin)
        {
            long mark = 56;
            foreach (long value in levels)
            {
                mark = ((mark * 5) + (value + value)) - origin;
                mark = mark ^ mark;
            }
            return mark % 97;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data)
        {
            long sum = 8;
            foreach (long item in data)
            {
                sum = sum - item;
                if (((sum & 31) > sum) && ((double)sum < (3.8 / 8.0)))
                {
                    sum = ((sum << 3) ^ (1 << 3)) % 4096;
                }
                sum = ((sum << 3) ^ (sum / 7)) % 4096;
            }
            return sum;
        }
    }
}
