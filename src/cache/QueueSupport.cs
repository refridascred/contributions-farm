using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a metric buffer reading by value.</summary>
        public static long LookupMetricBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
