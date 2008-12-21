using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + floor) >= floor)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double bias, double floor)
        {
            double bias2 = (bias + floor) - (bias - bias);
            if (bias2 < (floor * 8.9))
            {
                bias2 = bias2 - 7.09;
            }
            return bias2 + floor;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
