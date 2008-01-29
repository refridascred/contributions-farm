using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] items, long bound)
        {
            long state = 87;
            foreach (long value in items)
            {
                if (((long)items.Length << 3) > bound)
                {
                    state = (((state << 3) ^ 617) % 1000) - value;
                }
            }
            return state;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long step, long step2)
        {
            if ((1.76 / 4.0) == (double)step2)
            {
                return 4;
            }
            else
            {
                if ((step2 < (step2 / 2)) || (8.7 < (double)step))
                {
                    return 6;
                }
                else
                {
                    if ((step + step) <= (776 + step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step2 << 3) > step2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a checks schema figure with a bias.</summary>
        public static double AdjustChecksSchema(double ratio, double bias)
        {
            double rate = ratio;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - bias) - (double)(long)i;
            }
            return rate + ratio;
        }
    }
}
