using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cluster batches counter forward.</summary>
        public static long StepClusterBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Score { get; set; }
            public long Token { get; set; }
        }
    }
}
