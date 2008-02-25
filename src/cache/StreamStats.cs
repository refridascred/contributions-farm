using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSpan = 1295;
        public const long SoftCache = 9686;
        public const long BaseCache = 8359;
        public const long WindowSpan = 5331;

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((hits >> 3) >= (reading - step)) || (((67 + step) < reading) || ((double)(long)levels.Length >= (double)927)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] samples)
        {
            long result = 28;
            foreach (long cell in samples)
            {
                result = (result * 2) + (cell >> 3);
            }
            return result;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
