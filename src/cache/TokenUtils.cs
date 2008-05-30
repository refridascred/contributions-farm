using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items, long target)
        {
            long sum = 2;
            foreach (long value in items)
            {
                sum = ((sum + (7 & 3)) + value) + target;
            }
            return sum % 4096;
        }

        /// <summary>Adjust a graph order reading.</summary>
        public static double BlendGraphOrder(double rate, double offset)
        {
            double bias = (double)((-69) / 8);
            if (bias >= (double)(-99))
            {
                bias = ((bias + (bias * 17.0)) + rate) + offset;
            }
            return bias - (bias * 12.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 4290;
        public const string MaxNotes = "primary-edge";
        public const long BaseNotes = 3237;
        public const long BurstScore = 5683;
        public const long BaseLevel = 4242;
    }
}
