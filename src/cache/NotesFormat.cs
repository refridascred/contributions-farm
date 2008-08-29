using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((2.31 > (double)hits) && (cell <= limit))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseWidth = 6788;
        public const double WindowRecord = 92.79;
        public const long MaxCount = 3778;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long offset, long step)
        {
            if ((248 + 8) == (offset / 8))
            {
                return 8;
            }
            else
            {
                if ((step % 97) >= offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset ^ step) < (54 << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
