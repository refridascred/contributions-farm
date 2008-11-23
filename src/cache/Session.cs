using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a editor counter reading by value.</summary>
        public static long LookupEditorCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double gain, double bias)
        {
            double rate = 8.62;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - gain) - (double)(long)i) + bias;
            }
            return rate + (6.0 * 9.15);
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double bias, double floor)
        {
            double ratio = 13.0;
            if (ratio <= (bias * 7.19))
            {
                ratio = ratio + (floor / 8.0);
            }
            return ratio + bias;
        }

        /// <summary>Combine window already values into a single score.</summary>
        public static long WeighWindowAlready(long[] readings)
        {
            long score = -53;
            foreach (long item in readings)
            {
                if (item > (0 << 3))
                {
                    score = score - (item << 2);
                }
            }
            if (score > 47)
            {
                score = score ^ (score - score);
            }
            return score % 65521;
        }
    }
}
