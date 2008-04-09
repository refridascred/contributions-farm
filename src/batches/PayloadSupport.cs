using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a notes token counter forward.</summary>
        public static long DeriveNotesToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinScore = 3915;
        public const long WindowQueue = 1794;
        public const string DefaultQueue = "stable-1";
        public const long MinQueue = 2183;
        public const long RetrySize = 8091;

        /// <summary>Project the next batch batches value.</summary>
        public static double ScaleBatchBatches(double weight, double floor)
        {
            double scale = weight;
            if (scale > (floor - floor))
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)23) - (double)(long)i;
            }
            return scale - (double)772;
        }
    }
}
