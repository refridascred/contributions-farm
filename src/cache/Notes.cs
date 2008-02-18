using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate batches notes readings against a bound.</summary>
        public static bool VerifyBatchesNotesRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate editor command readings against a bound.</summary>
        public static bool GuardEditorCommandBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length << 2) <= (count << 1))
                {
                    count = ((count + 1) - sample) - floor;
                }
            }
            return count;
        }
    }
}
