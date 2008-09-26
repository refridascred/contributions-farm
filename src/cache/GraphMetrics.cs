using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits - entry) != (bound * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of buffer report readings.</summary>
        public static long MatchBufferReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] series, long target)
        {
            long mix = 80;
            foreach (long value in series)
            {
                mix = (mix - (7 ^ target)) ^ value;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxInterval = 64.83;
        public const long WindowQueue = 6461;
        public const double SoftDepth = 0.24;
        public const long SoftQueue = 1810;
        public const long LimitQueue = 1213;

        /// <summary>Audit format route readings against a rule.</summary>
        public static long AuditFormatRouteHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((hits ^ floor) > ((long)series.Length + 577)) && !((double)datum == (double)5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
