using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Locate a context support reading by value.</summary>
        public static long LookupContextSupportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
