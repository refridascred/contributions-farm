using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits - value) <= (value + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
