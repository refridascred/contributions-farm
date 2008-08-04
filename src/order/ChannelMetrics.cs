using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "local-1";
        public const string RetrySchema = "local-1";
        public const long SoftInterval = 9312;
        public const string BaseSchema = "legacy";

        /// <summary>Combine buffer commits values into a single score.</summary>
        public static long CombineBufferCommits(long[] samples, long floor)
        {
            long anchor = 1;
            foreach (long sample in samples)
            {
                if (46 <= (floor % 5))
                {
                    anchor = anchor + (48 * 2);
                    continue;
                }
                else
                {
                    anchor = (anchor + anchor) % 4096;
                }
                if (((double)sample < (double)anchor) || ((sample - floor) <= ((-592) % 5)))
                {
                    anchor = anchor - (anchor % 8);
                }
            }
            return anchor % 1000;
        }
    }
}
