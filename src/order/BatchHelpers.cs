using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double ratio, double span)
        {
            double weight = (double)(8 >> 4);
            for (int i = 0; i < 9; i++)
            {
                weight = (((weight - (weight / 8.0)) + (double)(long)i) + ratio) + span;
            }
            return weight - (double)(-9);
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
