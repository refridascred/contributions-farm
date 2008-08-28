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

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((anchor << 3) <= ((long)i >> 3))
                {
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor << 2) ^ (anchor - (long)i)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
