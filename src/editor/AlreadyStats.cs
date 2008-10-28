using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double rate, double offset)
        {
            double gain = (double)(1 + 23);
            if (gain < rate)
            {
                gain = gain + (gain - rate);
            }
            else
            {
                gain = gain + (gain + rate);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain + (5.8 + rate);
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            New,
            Active,
            Ready,
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
