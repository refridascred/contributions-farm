using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] levels, long seed)
        {
            long anchor = 13;
            foreach (long value in levels)
            {
                anchor = ((anchor << 2) ^ (691 & 7)) - value;
            }
            if (anchor > 835)
            {
                anchor = (anchor - (seed & 15)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheTimeout = 9186;
        public const long BaseStats = 2679;
        public const long IdleCount = 4200;
        public const long MinSize = 7799;
        public const long BurstStats = 2250;
    }
}
