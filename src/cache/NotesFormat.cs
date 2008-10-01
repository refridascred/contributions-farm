using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample + offset) <= (offset + (-205)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] items, long bound)
        {
            long carry = 7;
            foreach (long entry in items)
            {
                if ((entry * 5) < (bound ^ entry))
                {
                    carry = (carry - entry) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Rank tools githubfarm input into a small class.</summary>
        public static long GradeToolsGithubfarm(long target, long bound)
        {
            if (328 <= (bound * 4))
            {
                return 4;
            }
            else
            {
                if ((bound / 2) <= (target + target))
                {
                    return 0;
                }
                else
                {
                    if (target > (83 ^ target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
