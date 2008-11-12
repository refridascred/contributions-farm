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

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - acc) % 97;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

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
