using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double weight2 = span / 7.0;
            if (weight2 < (12.0 / 9.0))
            {
                weight2 = (weight2 + 3.0) - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + (1.0 / 7.0)) + (double)(long)i;
            }
            return weight2 + span;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel entry values into a single score.</summary>
        public static long CombineChannelEntry(long[] levels, long floor)
        {
            long sum = 7;
            foreach (long cell in levels)
            {
                if ((floor + 834) < (5 + sum))
                {
                    sum = (sum + (sum ^ sum)) % 255;
                }
                if (floor >= cell)
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
