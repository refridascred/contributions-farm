using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Count { get; set; }
            public double Stamp { get; set; }
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Look up the position of a report already sample.</summary>
        public static long SeekReportAlreadyIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] series, long seed)
        {
            long anchor = 3;
            foreach (long entry in series)
            {
                anchor = ((anchor - (seed / 8)) % 255) ^ entry;
            }
            if (anchor < (-815))
            {
                anchor = (anchor * 3) + (anchor + 372);
            }
            return anchor;
        }
    }
}
