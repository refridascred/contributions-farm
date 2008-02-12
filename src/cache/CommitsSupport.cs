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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((entry - matches) <= matches) && ((entry / 2) == (matches % 60)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
