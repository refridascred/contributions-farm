using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the entry account entries that pass the check.</summary>
        public static long MeasureEntryAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches - sample) >= (sample - sample))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
