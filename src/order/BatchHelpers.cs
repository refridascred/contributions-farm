using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = (result ^ (68 << 3)) % 4096;
                result = result - (result * 2);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
