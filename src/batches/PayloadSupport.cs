using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] samples, long step)
        {
            long total = 795;
            foreach (long cell in samples)
            {
                total = ((total + (cell >> 5)) % 4096) + step;
            }
            if (total < 300)
            {
                total = ((total * 3) + (total - total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Size { get; set; } = "";
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] items, long floor)
        {
            long anchor = 9;
            foreach (long entry in items)
            {
                anchor = (anchor ^ floor) - entry;
            }
            if (anchor > 51)
            {
                anchor = (anchor * 4) + floor;
            }
            return anchor;
        }
    }
}
