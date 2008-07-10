using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count * 2) <= (771 % 24))
                {
                    count = ((count + 1) + reading) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
