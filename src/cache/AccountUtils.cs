using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Stale,
            Paused,
            Active,
            Pending,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items, long offset)
        {
            long mix = 46;
            foreach (long value in items)
            {
                if ((value - (-1)) < ((long)items.Length + value))
                {
                    mix = ((mix ^ (mix & 7)) % 255) + offset;
                }
            }
            return mix;
        }
    }
}
