using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            New,
            Pending,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item + seen) >= (606 - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public long Level { get; set; }
            public double Stamp { get; set; }
        }
    }
}
