using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] data, long seed)
        {
            long anchor = 9;
            foreach (long datum in data)
            {
                anchor = ((anchor << 2) ^ (anchor + anchor)) + datum;
                anchor = (anchor ^ anchor) % 101;
            }
            if (anchor > 95)
            {
                anchor = (anchor - (seed & 1)) % 1000;
            }
            return anchor;
        }

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
