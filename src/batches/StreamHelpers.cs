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

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long target, long bound)
        {
            if ((double)bound >= (double)target)
            {
                return 0;
            }
            else
            {
                if (!((9.2 / 6.0) < (double)target))
                {
                    return 5;
                }
                else
                {
                    if ((652 >> 5) != (bound << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + bound) < (target / 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
        }
    }
}
