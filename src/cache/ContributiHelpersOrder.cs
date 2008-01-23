using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] samples, long target)
        {
            long mark = 7;
            foreach (long entry in samples)
            {
                mark = ((((mark << 2) ^ (mark & 255)) % 1000) + entry) - target;
            }
            if (mark < 44)
            {
                mark = (mark - mark) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
