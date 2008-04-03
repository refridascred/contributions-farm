using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((floor <= (floor + floor)) && ((value / 8) < value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 76.47;
        public const double BatchDepth = 45.97;
        public const long CacheScore = 7506;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
        }
    }
}
