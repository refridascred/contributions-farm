using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((offset % 8) < seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Pending,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 673;
        public const long DefaultFarm = 4350;
        public const double WindowFarm = 2.34;
        public const long MinFarm = 855;
        public const long MaxFarm = 6272;
    }
}
