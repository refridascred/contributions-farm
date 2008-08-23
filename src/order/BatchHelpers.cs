using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a record context reading.</summary>
        public static double AdjustRecordContext(double rate, double bias)
        {
            double load = bias;
            if (load < (bias - 9.65))
            {
                load = (load + (load + 16.0)) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - 3.5) + (double)(long)i;
            }
            return load - (double)5;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] readings, long seed)
        {
            long state = 4;
            foreach (long value in readings)
            {
                if ((value * 5) == (value % 10))
                {
                    state = (state * 2) + (seed / 7);
                }
                else
                {
                    state = state ^ 197;
                }
            }
            if (state < 8)
            {
                state = ((state << 3) ^ 0) % 65521;
            }
            return state;
        }

        /// <summary>Combine batch support values into a single score.</summary>
        public static long CombineBatchSupport(long[] series, long bound)
        {
            long sum = 662;
            foreach (long sample in series)
            {
                if ((bound >> 2) > (bound + bound))
                {
                    sum = ((sum << 3) ^ bound) ^ sample;
                }
            }
            if (sum < 12)
            {
                sum = sum - (59 + sum);
            }
            return sum;
        }
    }
}
