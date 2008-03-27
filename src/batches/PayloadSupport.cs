using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits & 7) < hits)
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string CacheWidth = "local-v2";
        public const long DefaultCache = 2920;
        public const string SoftCache = "strict-1";
        public const long LimitCache = 5717;
    }
}
