using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine editor counter values into a single score.</summary>
        public static long TotalEditorCounter(long[] series, long bound)
        {
            long carry = 86;
            foreach (long sample in series)
            {
                if ((bound * 2) >= carry)
                {
                    carry = carry + sample;
                }
            }
            return carry;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] levels, long bound)
        {
            long mix = 45;
            foreach (long cell in levels)
            {
                mix = (mix ^ (cell % 24)) - bound;
            }
            return mix % 65521;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long offset, long floor)
        {
            long span = offset + floor;
            if ((span / 9) >= offset)
            {
                return 7;
            }
            else
            {
                if ((175 % 12) == (floor + span))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
