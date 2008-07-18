using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long target, long bound)
        {
            if ((target << 1) <= target)
            {
                return 6;
            }
            else
            {
                if ((double)target == (4.0 - 8.13))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((seen + 580) > (item - seen)) || ((390 - 610) != (seen % 10))) || ((0.9 - 6.93) == (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
