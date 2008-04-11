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

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public long Ratio { get; set; }
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
