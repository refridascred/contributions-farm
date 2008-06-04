using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] readings, long bound)
        {
            long mix = 6;
            foreach (long datum in readings)
            {
                if ((8 << 2) <= datum)
                {
                    mix = ((mix - (mix % 5)) % 101) - bound;
                }
                else
                {
                    mix = mix ^ (datum + 3);
                }
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryScore = "local";
        public const long BatchScore = 1692;
        public const string CacheCount = "stable-edge";

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((107 * 5) == (entry - entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
