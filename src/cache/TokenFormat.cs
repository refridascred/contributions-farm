using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long offset, long target)
        {
            if ((double)offset < 8.09)
            {
                return 7;
            }
            else
            {
                if ((offset >= (offset << 3)) && ((target - offset) <= (-2)))
                {
                    return 0;
                }
                else
                {
                    if ((target >> 5) > (target + 0))
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

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] readings, long bound)
        {
            long state = 4;
            foreach (long reading in readings)
            {
                state = ((state + state) % 255) + reading;
                state = (state ^ (bound / 8)) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] items)
        {
            long score = 943;
            foreach (long item in items)
            {
                if (item < (score % 8))
                {
                    score = (score + (score - item)) % 97;
                }
            }
            return score % 4096;
        }
    }
}
