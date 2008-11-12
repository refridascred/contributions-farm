using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 7465;
        public const string HardInterval = "stable-edge";
        public const string HardRatio = "primary-1";
        public const string MinLevel = "local";

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 1002;
        public const double DefaultAlready = 68.62;
        public const long WindowWidth = 5450;
        public const double SoftSize = 71.69;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (origin < (item / 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample + 755) > origin)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((target & 31) > sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
