using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series)
        {
            long anchor = 555;
            foreach (long item in series)
            {
                if (item < (anchor >> 4))
                {
                    anchor = anchor - (59 << 3);
                }
                if (((anchor + (long)series.Length) != (anchor + 2)) && ((double)anchor > (3.29 * 12.0)))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
