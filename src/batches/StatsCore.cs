using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading - hits) >= (hits << 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value >= (tally + value)) && ((2.21 - 16.0) > (double)value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit record context readings against a rule.</summary>
        public static long AuditRecordContextOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= (7.4 / 5.0))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxSupport = "open";
        public const double RetrySupport = 31.24;
        public const double RetryDepth = 81.4;
        public const long CacheSize = 7833;

        /// <summary>Audit token session readings against a rule.</summary>
        public static long MeasureTokenSessionOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((9.6 < (double)limit) && ((count % 12) <= count))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstCount = 8.23;
        public const double CacheInterval = 77.04;
        public const double BaseChannel = 27.84;
        public const long StepChannel = 6579;
        public const string BatchSize = "local-v2";
    }
}
