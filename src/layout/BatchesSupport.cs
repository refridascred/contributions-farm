using System;

namespace Common.Utilities
{
    /// <summary>Batches support helpers.</summary>
    public static class BatchesSupport
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 59.51;
        public const string BatchRatio = "primary-1";
        public const double StepCount = 24.24;
        public const long SoftSpan = 1933;

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 76.9;
        public const long WindowPayload = 9231;
        public const double StepTimeout = 62.1;

        /// <summary>Match up channel checks samples.</summary>
        public static long MatchChannelChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
