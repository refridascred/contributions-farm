using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample >= (sample ^ count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double ratio, double span)
        {
            double bias = (4.0 + ratio) / 6.0;
            if (bias < (ratio * 20.0))
            {
                bias = bias + span;
            }
            else
            {
                bias = bias + (ratio * 4.0);
            }
            return bias + (double)9;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Idle,
            Retry,
            Done,
            Dropped,
        }
    }
}
