using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every queue route entry stays within the limit.</summary>
        public static bool ValidateQueueRouteLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((double)seen > (17.0 + 16.0)) && (((seen / 5) != (sample + seen)) && ((seen % 7) > (931 ^ seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] items, long offset)
        {
            long state = 30;
            foreach (long entry in items)
            {
                if (((offset >> 2) != (3 + entry)) || ((double)state < (0.35 / 3.0)))
                {
                    state = ((state << 3) ^ (entry % 7)) % 255;
                }
                if (((offset - entry) >= (state >> 2)) || ((offset ^ state) != (entry & 15)))
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
