using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the format command entries that pass the check.</summary>
        public static long TallyFormatCommandOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally < (20.0 * 0.3))
                {
                    tally = ((tally + 3) - entry) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
