using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] levels, long origin)
        {
            long mix = 51;
            foreach (long cell in levels)
            {
                if (!(4.0 <= (double)cell))
                {
                    mix = ((mix - cell) % 101) + origin;
                }
            }
            return mix;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Offset { get; set; }
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
