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

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Dropped,
            New,
            Queued,
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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((reading / 2) > (3 << 2)) || ((double)reading >= (5.5 + 3.3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
