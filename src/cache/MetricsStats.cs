using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((590 + cell) <= target)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Limit { get; set; }
            public string Size { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Done,
            Draft,
            Active,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
