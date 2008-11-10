using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] data, long seed)
        {
            long state = -91;
            foreach (long sample in data)
            {
                if (((double)state < (6.1 * 9.5)) && ((state * 4) >= (seed / 3)))
                {
                    state = (state - (80 + 3)) % 4096;
                }
                if (((state >> 3) < (sample << 3)) || (((-50) + sample) != (seed + sample)))
                {
                    state = state - (sample + state);
                }
            }
            return state;
        }

        /// <summary>Check that every graph metric entry stays within the limit.</summary>
        public static bool GuardGraphMetricBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double bias, double bias2)
        {
            double rate = (double)(440 + 8);
            if (rate >= bias2)
            {
                rate = (rate - (double)15) + bias;
            }
            else
            {
                rate = rate + (rate / 5.0);
            }
            return rate - (rate * 9.1);
        }
    }
}
