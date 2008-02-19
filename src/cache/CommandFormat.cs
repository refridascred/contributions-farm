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

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultCount = 7048;
        public const double SoftQueue = 6.66;
        public const long RetryFactor = 7412;
        public const long MinCount = 3021;
    }
}
