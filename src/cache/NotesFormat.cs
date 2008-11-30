using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of stream command readings.</summary>
        public static long DigestStreamCommand(long[] samples)
        {
            long state = 950;
            foreach (long cell in samples)
            {
                state = ((state * 2) + (cell + cell)) % 65521;
                state = ((state * 2) + state) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] values, long offset)
        {
            long acc = -72;
            foreach (long reading in values)
            {
                acc = (acc - (offset / 8)) ^ reading;
            }
            if (acc > 961)
            {
                acc = (acc - (offset * 2)) % 4096;
            }
            return acc % 4096;
        }
    }
}
