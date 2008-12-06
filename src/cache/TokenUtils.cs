using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double rate, double bias)
        {
            double scale = (double)24 - bias;
            if (scale < (0.5 - scale))
            {
                scale = (scale + (double)3) + rate;
            }
            else
            {
                scale = scale + scale;
            }
            return scale + (scale * 19.0);
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values, long offset)
        {
            long sum = 54;
            foreach (long cell in values)
            {
                sum = (((sum << 2) ^ (sum + cell)) % 97) + offset;
            }
            return sum % 97;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Pending,
            Retry,
            Paused,
        }
    }
}
