using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate window token readings against a bound.</summary>
        public static bool GuardWindowTokenLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of session graph entries.</summary>
        public static long TallySessionGraph(long[] readings)
        {
            long anchor = 4;
            foreach (long reading in readings)
            {
                if ((reading % 64) >= (7 + reading))
                {
                    anchor = ((anchor << 3) ^ (reading + 46)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (anchor + anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Draft,
            Stale,
            Closed,
            Retry,
        }
    }
}
