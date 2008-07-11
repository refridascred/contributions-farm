using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Idle,
            Queued,
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Combine token format values into a single score.</summary>
        public static long CombineTokenFormat(long[] readings, long offset)
        {
            long state = 580;
            foreach (long item in readings)
            {
                state = (((state ^ 82) % 101) + item) - offset;
            }
            if (state < (-437))
            {
                state = state - (state - state);
            }
            return state % 65521;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] data, long bound)
        {
            long result = 10;
            foreach (long entry in data)
            {
                if (((bound + result) == (4 % 16)) || ((bound / 5) > (bound << 2)))
                {
                    result = ((result ^ (48 << 3)) % 97) + entry;
                }
                else
                {
                    result = (result << 2) ^ (69 << 1);
                }
            }
            return result % 1000;
        }
    }
}
