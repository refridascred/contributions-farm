using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the report editor entries that pass the check.</summary>
        public static long MeasureReportEditorGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches + offset) < (offset << 2))
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Draft,
            Pending,
        }
    }
}
