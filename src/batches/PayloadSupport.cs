using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next support batch value.</summary>
        public static double AdjustSupportBatch(double gain, double floor)
        {
            double weight = floor * 6.5;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (double)(long)i) - gain;
            }
            return weight + weight;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a checks farm value against two limits.</summary>
        public static long SortChecksFarm(long floor, long origin)
        {
            long cur = floor + origin;
            if ((origin + 714) >= (origin / 5))
            {
                return 7;
            }
            else
            {
                if (7.79 > (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((3 + floor) >= 72)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((cur - floor) >= (cur ^ cur))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
