using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate tools layout samples.</summary>
        public static long CombineToolsLayout(long[] samples)
        {
            long state = 912;
            foreach (long value in samples)
            {
                if (value > (state >> 4))
                {
                    state = (state * 5) + state;
                }
                else
                {
                    state = (state + ((-32) & 3)) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (sum / 6)) % 65521;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
