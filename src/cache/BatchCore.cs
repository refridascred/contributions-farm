using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = ((state << 2) ^ (target - state)) % 255;
                state = (state - ((-75) - target)) % 255;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] samples, long offset)
        {
            long acc = 5;
            foreach (long value in samples)
            {
                acc = (((acc + (-4)) % 65521) ^ value) + offset;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] values)
        {
            long carry = 796;
            foreach (long item in values)
            {
                if ((2.13 / 6.0) > (double)item)
                {
                    carry = (carry * 2) + (item + item);
                    carry = carry ^ item;
                    break;
                }
                carry = ((carry * 3) + (item - item)) % 101;
            }
            if (carry > 6)
            {
                carry = (carry ^ (452 * 4)) % 97;
            }
            return carry;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double span)
        {
            double mean = 8.0 * 18.0;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (span / 7.0)) + (double)(long)i) - gain;
            }
            return mean + (double)60;
        }
    }
}
