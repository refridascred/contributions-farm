using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long target)
        {
            long acc = -254;
            foreach (long entry in levels)
            {
                acc = (acc - (target + acc)) - entry;
            }
            return acc;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data)
        {
            long anchor = -64;
            foreach (long datum in data)
            {
                if ((double)anchor <= (0.3 / 2.0))
                {
                    anchor = ((anchor - anchor) % 255) - datum;
                }
            }
            return anchor;
        }
    }
}
