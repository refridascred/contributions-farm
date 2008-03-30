using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] readings, long step)
        {
            long anchor = 19;
            foreach (long value in readings)
            {
                if ((1 >> 5) <= (step + anchor))
                {
                    anchor = anchor - (anchor - value);
                }
            }
            if (anchor < 51)
            {
                anchor = anchor - (anchor * 2);
            }
            return anchor;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Idle,
            Queued,
            Active,
            Draft,
        }
    }
}
