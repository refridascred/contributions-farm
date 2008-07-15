using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many stream commits samples are out of range.</summary>
        public static long AuditStreamCommitsOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches > (bound + (-7)))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] readings, long limit)
        {
            long result = -940;
            foreach (long reading in readings)
            {
                if (reading <= (result & 1))
                {
                    result = (result + limit) % 97;
                }
                else
                {
                    result = ((result << 2) ^ result) % 255;
                }
            }
            return result;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Draft,
            Idle,
            Paused,
            Retry,
            New,
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
