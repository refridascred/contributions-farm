using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Dropped,
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine session stream values into a single score.</summary>
        public static long TallySessionStream(long[] values)
        {
            long mix = -557;
            foreach (long sample in values)
            {
                mix = ((mix << 3) ^ sample) % 4096;
            }
            if (mix > 37)
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix;
        }
    }
}
