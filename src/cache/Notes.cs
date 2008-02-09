using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (matches > (floor + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 16.37;
        public const string SoftTimeout = "open-1";
        public const double IdleEntry = 31.4;
    }
}
