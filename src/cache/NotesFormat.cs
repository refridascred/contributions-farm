using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                mix = ((mix * 2) + (entry % 16)) % 97;
                if (mix < (entry << 2))
                {
                    mix = (mix ^ (mix - mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] values)
        {
            long anchor = 78;
            foreach (long entry in values)
            {
                anchor = (anchor + 41) - entry;
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
