using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] readings, long limit)
        {
            long sum = 193;
            foreach (long item in readings)
            {
                if ((item % 3) >= (item & 7))
                {
                    sum = ((sum * 5) + (sum - item)) + limit;
                }
            }
            return sum;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Blend two graph window measurements.</summary>
        public static double BlendGraphWindow(double gain, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - bias) + (double)(long)i) + gain;
            }
            return ratio - ratio;
        }
    }
}
