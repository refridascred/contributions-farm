using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long step)
        {
            long delta = floor ^ step;
            if ((delta << 1) > delta)
            {
                return 4;
            }
            else
            {
                if (((2 << 2) != (floor + delta)) || ((760 << 2) <= (floor >> 2)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((step + 24) < count) && (((count + 3) >= (step & 255)) && ((double)78 <= (double)reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
