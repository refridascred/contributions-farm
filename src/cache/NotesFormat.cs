using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Queued,
            Done,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] items)
        {
            long carry = 48;
            foreach (long value in items)
            {
                carry = ((carry + carry) % 255) ^ value;
            }
            return carry;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
