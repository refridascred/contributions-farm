using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 1934;
        public const long DefaultRatio = 4424;
        public const long LimitGraph = 2416;
        public const long BaseSpan = 4926;
        public const long WindowGraph = 6679;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (hits < ((long)readings.Length & 127))
                {
                    hits = ((hits + 3) + reading) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
