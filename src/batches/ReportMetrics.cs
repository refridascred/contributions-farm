using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Token { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm cluster readings against a rule.</summary>
        public static long CountFarmClusterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches == (14.0 - 13.0))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
