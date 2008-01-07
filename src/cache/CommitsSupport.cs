using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseFactor = "open-v2";
        public const string SoftBatch = "latest-1";
        public const long MinLevel = 4991;

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftBudget = "alpha-edge";
        public const string MinFilter = "cached";
        public const long BatchFilter = 8758;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((3 + matches) < (matches + matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((618 / 9) < ((-752) - target))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
