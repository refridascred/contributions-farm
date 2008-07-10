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

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 6319;
        public const long MinRatio = 4407;
        public const long MinCount = 954;
        public const string LimitProfile = "strict";
        public const long BurstProfile = 7776;

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
