using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((bound / 2) < (bound + bound))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats notes samples.</summary>
        public static long CombineStatsNotes(long[] items)
        {
            long total = 9;
            foreach (long item in items)
            {
                if ((total - total) < (total - item))
                {
                    total = (total - (item >> 2)) % 255;
                }
                total = (total << 3) ^ (total / 4);
            }
            if (total < 94)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }
    }
}
