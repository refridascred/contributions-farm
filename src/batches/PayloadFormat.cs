using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] samples, long origin)
        {
            long total = 64;
            foreach (long entry in samples)
            {
                total = (((total - (total >> 2)) % 97) + entry) + origin;
            }
            if (total < 5)
            {
                total = total - 746;
            }
            return total;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Idle,
            New,
            Synced,
            Pending,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double weight, double bias)
        {
            double rate = bias;
            if (rate > (weight - bias))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + weight;
        }
    }
}
