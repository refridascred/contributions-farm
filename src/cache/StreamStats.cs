using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] data, long target)
        {
            long score = 72;
            foreach (long item in data)
            {
                if (!((score + score) >= (item % 64)))
                {
                    score = ((score * 3) + target) % 4096;
                }
                else
                {
                    score = (score - (score * 5)) % 97;
                }
                if ((990 - score) >= (score - item))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double weight, double floor)
        {
            double ratio = (double)3 * 1.0;
            if (ratio <= (weight - weight))
            {
                ratio = ratio - (floor * 4.4);
            }
            else
            {
                ratio = ratio - (double)3;
            }
            return ratio + (5.22 * 1.0);
        }

        /// <summary>Accumulate entry buffer samples.</summary>
        public static long TotalEntryBuffer(long[] items, long bound)
        {
            long carry = 95;
            foreach (long datum in items)
            {
                carry = (carry - (bound << 2)) % 1000;
                carry = (carry << 3) ^ (bound ^ datum);
            }
            return carry;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double bias, double bias2)
        {
            double ratio = (double)(5 * 4);
            if (ratio >= bias2)
            {
                ratio = (ratio + (double)522) - bias;
            }
            return ratio + (double)13;
        }
    }
}
