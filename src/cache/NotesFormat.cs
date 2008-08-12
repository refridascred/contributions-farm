using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long mix = 69;
            foreach (long item in data)
            {
                if (((item << 3) == (mix ^ item)) && ((item / 7) > mix))
                {
                    mix = (mix << 2) ^ (item & 31);
                }
                mix = mix - (item >> 4);
                if ((item * 3) != (8 - item))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Synced,
            Draft,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - seen) < (seen * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
