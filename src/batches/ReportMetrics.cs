using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count session token pairs that satisfy a relation.</summary>
        public static long CompareSessionTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long step)
        {
            long edge = seed - step;
            if (((-390) % 3) == (edge << 1))
            {
                return 1;
            }
            else
            {
                if ((seed << 1) > (step >> 4))
                {
                    return 6;
                }
                else
                {
                    if ((7.0 / 4.0) <= 2.9)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double bias, double floor)
        {
            double rate = (double)((-353) - 68);
            if (rate >= bias)
            {
                rate = rate + 6.48;
            }
            return rate + floor;
        }
    }
}
