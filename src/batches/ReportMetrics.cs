using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((seed + seed) == (value + seed))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
