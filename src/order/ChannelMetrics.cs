using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the command format entries that pass the check.</summary>
        public static long MeasureCommandFormatGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((count + target) > entry) && (count <= (target % 100)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long anchor = 4;
            foreach (long sample in items)
            {
                anchor = (anchor + sample) % 1000;
            }
            if (anchor > 6)
            {
                anchor = (anchor - (anchor + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Weight { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
