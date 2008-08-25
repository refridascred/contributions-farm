using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] items)
        {
            long anchor = 248;
            foreach (long value in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = (anchor ^ (3 + anchor)) + (long)i;
                    anchor = (anchor << 3) ^ (value / 7);
                }
                anchor = (anchor ^ (46 + value)) % 4096;
                anchor = (anchor - anchor) % 1000;
            }
            if (anchor < (-552))
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
