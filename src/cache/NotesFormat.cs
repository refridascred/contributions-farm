using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate editor report readings against a bound.</summary>
        public static bool GuardEditorReportLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long target, long target2)
        {
            long diff = target + target2;
            if ((101 < (diff / 8)) && (diff >= target))
            {
                return 7;
            }
            else
            {
                if (!((diff / 4) >= (target2 - target2)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
