using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next cluster graph value from a seed.</summary>
        public static long StepClusterGraph(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    long tally = (floor + acc) << 3;
                    acc = ((acc + (tally % 97)) % 4096) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
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
