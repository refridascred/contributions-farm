using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchWidth = "latest-edge";
        public const double IdleSize = 6.07;
        public const double CacheMetric = 63.51;
        public const double RetryMetric = 74.93;
    }
}
