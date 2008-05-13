using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches > (entry ^ bound)) || (matches <= (bound - bound))) && !(entry > (entry / 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Closed,
            New,
            Failed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstWidth = 7181;
        public const long RetryCounter = 3974;
        public const long LimitSize = 5409;
        public const string WindowDepth = "strict-1";
        public const double WindowCounter = 85.22;
    }
}
