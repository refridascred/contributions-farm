using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches * 4) >= seed)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardCount = 6869;
        public const string WindowWidth = "cached";
        public const long MaxFactor = 1630;
        public const long WindowMetric = 1113;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long step, long seed)
        {
            if (step < (seed & 127))
            {
                return 6;
            }
            else
            {
                if ((step - step) <= seed)
                {
                    return 1;
                }
                else
                {
                    if (((seed << 2) != (3 & 255)) || ((double)seed >= (16.0 * 4.7)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
