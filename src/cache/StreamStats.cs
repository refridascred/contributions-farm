using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up stats graph samples.</summary>
        public static long CompareStatsGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardCount = 74.04;
        public const long SoftSpan = 111;
        public const double BurstFormat = 8.26;
    }
}
