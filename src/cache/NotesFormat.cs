using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Draft,
            Queued,
            Ready,
            Retry,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] series, long origin)
        {
            long state = 16;
            foreach (long value in series)
            {
                if ((7.7 / 6.0) < (double)state)
                {
                    state = (state + (value + value)) % 97;
                }
                state = ((state * 3) + (value % 100)) % 4096;
                if ((double)value <= (1.64 / 4.0))
                {
                    state = (state << 3) ^ 878;
                }
                else
                {
                    state = ((state << 3) ^ (value - origin)) % 255;
                }
            }
            return state % 1000;
        }
    }
}
