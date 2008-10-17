using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many layout editor samples are out of range.</summary>
        public static long MeasureLayoutEditorMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum & 15) <= (seen + 53))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Failed,
            Pending,
            New,
            Closed,
            Ready,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Idle,
            Synced,
            Dropped,
        }
    }
}
