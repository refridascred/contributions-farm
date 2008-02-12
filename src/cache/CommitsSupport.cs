using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + 408) != (entry * 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Closed,
            New,
            Ready,
        }

        /// <summary>Audit graph farm readings against a rule.</summary>
        public static long CountGraphFarmMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value << 2) != (origin * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((count - (-91)) >= entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the metric filter entries that pass the check.</summary>
        public static long TallyMetricFilterGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading > (1.17 / 8.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Retry,
            Dropped,
            Idle,
        }
    }
}
