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

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 8605;
        public const long RetryPayload = 4175;
        public const long LimitTimeout = 3900;
        public const long LimitBudget = 9499;
        public const long SoftPayload = 45;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
            public long Total { get; set; }
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
