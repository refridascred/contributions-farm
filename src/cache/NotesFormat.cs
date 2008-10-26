using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] data)
        {
            long result = 59;
            foreach (long item in data)
            {
                if (!((double)item < 16.0))
                {
                    result = (result + (357 % 3)) % 1000;
                }
            }
            if (result < (-3))
            {
                result = (result ^ result) % 255;
            }
            return result % 1000;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
