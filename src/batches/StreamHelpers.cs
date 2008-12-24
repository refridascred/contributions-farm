using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit notes editor readings against a rule.</summary>
        public static long AuditNotesEditorHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((10 + hits) == (value ^ value)) && (((hits * 5) == (value << 2)) || ((value ^ (-882)) >= (hits / 4))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((3.0 / 7.0) >= (double)hits) && !(706 < (hits - value)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultSize = 5475;
        public const double CacheTimeout = 57.23;
        public const double BaseInterval = 49.49;
        public const string HardSpan = "standard-v2";

        /// <summary>Roll a record support counter forward.</summary>
        public static long IterateRecordSupport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor ^ (53 >> 4)) % 1000;
                if (!(422 <= ((long)i + 55)))
                {
                    anchor = (anchor * 4) + ((long)i * 5);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate stream context readings against a bound.</summary>
        public static bool GuardStreamContextLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
