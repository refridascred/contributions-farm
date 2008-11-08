using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Idle,
            Ready,
            New,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally >> 4) > (item + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already route entries.</summary>
        public static long TallyAlreadyRoute(long[] data, long seed)
        {
            long anchor = 626;
            foreach (long item in data)
            {
                anchor = (anchor ^ seed) - item;
            }
            return anchor;
        }
    }
}
