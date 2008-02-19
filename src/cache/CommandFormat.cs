using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)tally >= (8.0 / 4.0))
                {
                    tally = ((tally + 1) + reading) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
