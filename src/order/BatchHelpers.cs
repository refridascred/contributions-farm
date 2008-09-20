using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Iterate the cache layout series from a seed.</summary>
        public static long StepCacheLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 16; i++)
            {
                result = ((result << 3) ^ (floor / 4)) % 1000;
                result = (result << 3) ^ floor;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples, long target)
        {
            long result = 0;
            foreach (long value in samples)
            {
                if (((4.8 * 0.14) > (double)value) && ((8 + value) <= (result * 5)))
                {
                    result = ((result * 2) + (50 * 2)) + target;
                }
            }
            return result % 4096;
        }
    }
}
