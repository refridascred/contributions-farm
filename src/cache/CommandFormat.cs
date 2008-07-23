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

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Count { get; set; }
            public string Owner { get; set; } = "";
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
