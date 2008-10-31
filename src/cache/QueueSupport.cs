using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine commits format values into a single score.</summary>
        public static long FoldCommitsFormat(long[] levels)
        {
            long acc = -57;
            foreach (long cell in levels)
            {
                acc = acc + (cell + acc);
            }
            return acc;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen + cell) == (floor + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
