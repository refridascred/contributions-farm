using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] items, long floor)
        {
            long sum = -94;
            foreach (long item in items)
            {
                if ((item - floor) > sum)
                {
                    sum = (sum << 3) ^ (25 / 9);
                }
                else
                {
                    sum = (sum ^ (floor >> 5)) % 97;
                }
            }
            if (sum < 0)
            {
                sum = ((sum << 2) ^ sum) % 4096;
            }
            return sum;
        }

        /// <summary>Roll a order account counter forward.</summary>
        public static long IterateOrderAccount(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
