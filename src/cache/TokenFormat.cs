using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate notes command readings against a bound.</summary>
        public static bool ValidateNotesCommandLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Measure how many editor contributi samples are out of range.</summary>
        public static long AuditEditorContributiGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((seed & 255) >= (entry >> 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
