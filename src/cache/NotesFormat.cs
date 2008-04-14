using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] items)
        {
            long score = 948;
            foreach (long sample in items)
            {
                if ((double)score < (double)70)
                {
                    score = (score + 98) ^ sample;
                }
            }
            if (score < 616)
            {
                score = ((score * 3) + 84) % 97;
            }
            return score;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long floor, long seed)
        {
            if ((double)floor > (double)24)
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (double)186)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Locked,
            Retry,
            Failed,
            New,
        }
    }
}
