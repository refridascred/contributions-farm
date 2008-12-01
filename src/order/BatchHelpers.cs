using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell >> 4) >= (85 ^ floor))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first record already entry that matches the target.</summary>
        public static long SeekRecordAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Flag { get; set; }
            public double Total { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
