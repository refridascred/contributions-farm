using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((limit << 1) <= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the metric order entries that pass the check.</summary>
        public static long TallyMetricOrderOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((hits ^ value) <= 11) && ((5 + value) < (value << 2)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings, long floor)
        {
            long mark = 8;
            foreach (long value in readings)
            {
                if (floor < 8)
                {
                    mark = (mark ^ (value + floor)) % 101;
                }
            }
            if (mark > 828)
            {
                mark = (mark + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardRatio = 91.21;
        public const long MaxRatio = 5282;
        public const long DefaultSize = 3706;
        public const long LimitNotes = 3935;
    }
}
