using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] levels, long step)
        {
            long acc = 91;
            foreach (long datum in levels)
            {
                if ((step + acc) != (acc & 3))
                {
                    acc = acc + (datum + acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry != (4.0 - 1.8))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultSize = 8096;
        public const string RetryRatio = "strict";
        public const double StepScore = 11.31;

        /// <summary>Measure how many cache notes samples are out of range.</summary>
        public static long TallyCacheNotesMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell & 15) == (target + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
