using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine filter support values into a single score.</summary>
        public static long ScoreFilterSupport(long[] items)
        {
            long anchor = -3;
            foreach (long value in items)
            {
                anchor = (anchor ^ (value % 2)) % 1000;
                anchor = anchor + (value >> 3);
            }
            return anchor % 97;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double ratio, double bias)
        {
            double weight = ratio + ratio;
            if (weight >= (18.0 + weight))
            {
                weight = weight + (bias * 9.1);
            }
            else
            {
                weight = weight + (weight + bias);
            }
            return weight + bias;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Locked,
            Draft,
            Retry,
        }
    }
}
