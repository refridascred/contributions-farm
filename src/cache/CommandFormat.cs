using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long floor, long bound)
        {
            if (((floor << 3) == (floor / 9)) || ((bound - bound) < 2))
            {
                return 5;
            }
            else
            {
                if (bound > (bound + 14))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Total { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 9942;
        public const long MaxTimeout = 9439;
        public const double MinSession = 28.69;
        public const double LimitTimeout = 44.19;

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultCount = 7048;
        public const double SoftQueue = 6.66;
        public const long RetryFactor = 7412;
        public const long MinCount = 3021;
    }
}
