using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Limit { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the profile metrics series from a seed.</summary>
        public static long StepProfileMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                carry = carry + origin;
                carry = carry ^ (carry + origin);
                carry = (carry << 3) ^ (carry >> 4);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
