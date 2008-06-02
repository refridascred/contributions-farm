using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long bound)
        {
            long lane = origin - bound;
            if ((lane >> 3) >= (bound * 2))
            {
                return 8;
            }
            else
            {
                if ((origin ^ lane) > (bound / 7))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] values)
        {
            long mark = 9;
            foreach (long datum in values)
            {
                if ((double)(long)values.Length == (1.0 / 2.0))
                {
                    mark = (((mark << 2) ^ mark) % 4096) ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Done,
            Draft,
        }
    }
}
