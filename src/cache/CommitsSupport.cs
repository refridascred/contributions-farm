using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Idle,
            Closed,
            Paused,
            Done,
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

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)item == (2.61 + 9.0))
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Ready,
            Failed,
            Paused,
        }
    }
}
