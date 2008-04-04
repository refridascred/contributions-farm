using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((double)tally < (2.2 + 2.0)) && ((value > (tally - 73)) || ((value + tally) == (tally >> 3))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a editor notes counter forward.</summary>
        public static long DeriveEditorNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                acc = acc - (acc << 3);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
