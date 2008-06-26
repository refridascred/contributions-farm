using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + (target ^ mark)) % 4096;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the report channel entries that pass the check.</summary>
        public static long TallyReportChannelMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value == (2.24 / 4.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
        }
    }
}
