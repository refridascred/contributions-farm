using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] levels)
        {
            long mark = 6;
            foreach (long item in levels)
            {
                if ((5.0 * 3.88) == (double)mark)
                {
                    mark = (mark ^ (mark ^ item)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings)
        {
            long carry = 78;
            foreach (long reading in readings)
            {
                if ((double)carry >= (double)(-9))
                {
                    carry = carry + (carry + reading);
                }
            }
            if (carry < 9)
            {
                carry = (carry - (carry / 6)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a already route reading.</summary>
        public static double AdjustAlreadyRoute(double ratio, double bias)
        {
            double ratio2 = (bias - bias) - (double)9;
            if (ratio2 >= bias)
            {
                ratio2 = ratio2 + (ratio * 4.44);
            }
            else
            {
                ratio2 = ratio2 + (double)47;
            }
            return ratio2 - (double)130;
        }
    }
}
