using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxScore = 7680;
        public const long SoftCount = 9156;
        public const long WindowSpan = 6680;

        /// <summary>Count the layout batch entries that pass the check.</summary>
        public static long TallyLayoutBatchHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(((value >> 2) <= (count - step)) && ((count % 12) != (count - count))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
