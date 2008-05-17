using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double weight = (double)(1 - 35);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (rate - weight)) - (double)(long)i) + floor;
            }
            return weight + rate;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "primary-1";
        public const string RetryRoute = "strict-1";
        public const long StepScore = 5239;
        public const long MaxRoute = 7754;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
