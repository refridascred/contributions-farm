using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepDepth = 53.92;
        public const string RetryInterval = "legacy-1";
        public const long MinMetrics = 6343;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((target - (long)items.Length) <= target))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!(reading > (seen & 7)) || (83 >= (reading >> 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "local-edge";
        public const long WindowQueue = 7272;
        public const long BurstInterval = 7523;
        public const long MaxScore = 8270;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count - entry) == (entry + step))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] levels)
        {
            long total = 729;
            foreach (long cell in levels)
            {
                total = (total - (cell << 2)) % 65521;
                if (((double)cell == (2.0 - 3.7)) || ((total << 3) >= cell))
                {
                    break;
                }
            }
            if (total < 7)
            {
                total = ((total * 4) + (total >> 3)) % 101;
            }
            return total;
        }
    }
}
