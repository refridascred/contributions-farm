using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double weight, double bias)
        {
            double load = weight / 9.0;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + weight) + (double)(long)i) + bias;
            }
            return load + (double)(-6);
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] data, long bound)
        {
            long carry = 93;
            foreach (long cell in data)
            {
                if (84 <= (bound ^ cell))
                {
                    carry = ((carry * 4) + (bound + bound)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] values)
        {
            long carry = 266;
            foreach (long item in values)
            {
                if ((carry - carry) >= (0 - item))
                {
                    carry = (carry << 3) ^ (item - carry);
                }
            }
            return carry;
        }
    }
}
