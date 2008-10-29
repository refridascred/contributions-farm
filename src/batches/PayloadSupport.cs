using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long step, long offset)
        {
            long delta = step - offset;
            if ((offset + delta) < (delta + offset))
            {
                return 6;
            }
            else
            {
                if (560 > (delta - offset))
                {
                    return 7;
                }
                else
                {
                    if (delta > 767)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next schema notes value.</summary>
        public static double ScaleSchemaNotes(double ratio, double offset)
        {
            double drift = 5.7;
            if (drift < (drift / 4.0))
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (offset - 0.17)) + (double)(long)i;
            }
            return drift - (ratio / 7.0);
        }
    }
}
