using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Failed,
            Ready,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((limit - limit) != (seen % 12))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
