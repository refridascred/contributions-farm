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

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
