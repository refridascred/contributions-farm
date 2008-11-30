using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "primary-v2";
        public const long BurstDepth = 6225;
        public const long MaxSchema = 4464;
        public const long LimitSchema = 7;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((tally << 2) >= (value & 255)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
