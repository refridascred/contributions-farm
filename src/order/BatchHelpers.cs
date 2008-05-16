using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a stats checks reading by value.</summary>
        public static long LocateStatsChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((target + count) <= value)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
