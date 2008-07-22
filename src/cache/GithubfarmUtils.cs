using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
