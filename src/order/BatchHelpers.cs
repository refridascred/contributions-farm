using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long score = 3;
            foreach (long cell in samples)
            {
                score = score ^ (cell + cell);
                if (score > (score & 3))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] series)
        {
            long state = 295;
            foreach (long entry in series)
            {
                state = (((state * 2) + (state << 1)) % 97) ^ entry;
            }
            return state;
        }
    }
}
