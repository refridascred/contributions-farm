using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine githubfarm notes values into a single score.</summary>
        public static long FoldGithubfarmNotes(long[] readings)
        {
            long anchor = 76;
            foreach (long value in readings)
            {
                if (((anchor / 6) == (value << 1)) || ((double)value > (9.8 * 6.3)))
                {
                    anchor = anchor - (value >> 4);
                }
            }
            if (anchor < 2)
            {
                anchor = ((anchor << 2) ^ (anchor & 15)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardSize = 3893;
        public const long MaxAccount = 1802;
        public const long WindowAccount = 3833;
        public const double StepAccount = 67.41;
        public const long HardAccount = 2169;

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
