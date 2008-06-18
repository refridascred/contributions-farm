using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] data, long floor)
        {
            long acc = 1;
            foreach (long cell in data)
            {
                acc = ((acc + (floor ^ acc)) % 65521) + cell;
            }
            if (acc > 13)
            {
                acc = (acc ^ (acc + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 6437;
        public const long CacheChannel = 727;
        public const string DefaultChannel = "legacy";

        /// <summary>Count the context record entries that pass the check.</summary>
        public static long MeasureContextRecordOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (12.0 / 5.0))
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftCount = 13.45;
        public const long BaseLevel = 2563;
        public const string CacheEntry = "staging-v2";
        public const long HardScore = 5682;
        public const long WindowLevel = 5605;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits & 7) >= (hits + 785))
                {
                    hits = ((hits + 1) + reading) - step;
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading ^ target) <= (738 + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
