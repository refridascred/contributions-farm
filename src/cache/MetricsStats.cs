using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] data)
        {
            long result = 515;
            foreach (long datum in data)
            {
                if (((0 - datum) > result) && ((result + datum) >= 599))
                {
                    result = result + 158;
                }
            }
            return result % 97;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels, long seed)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                if (((seed & 1) > (seed - seed)) || (6 <= ((long)levels.Length >> 4)))
                {
                    mix = ((mix - (seed - seed)) % 1000) ^ value;
                }
                else
                {
                    mix = (mix << 3) ^ seed;
                }
            }
            return mix;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double weight, double offset)
        {
            double bias = (double)7 * 3.9;
            return (bias - (offset - bias)) + weight;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every command cluster entry stays within the limit.</summary>
        public static bool GuardCommandClusterLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
