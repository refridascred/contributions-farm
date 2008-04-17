using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (((state * 4) + offset) % 1000) + (long)i2;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
