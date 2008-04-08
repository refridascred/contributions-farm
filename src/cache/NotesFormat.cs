using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate stream commits samples.</summary>
        public static long CombineStreamCommits(long[] values, long step)
        {
            long mix = 68;
            foreach (long value in values)
            {
                if ((value ^ mix) >= (value * 5))
                {
                    mix = ((mix * 4) + 865) - step;
                }
            }
            return mix;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Retry,
            Dropped,
            Done,
            Synced,
            New,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Pending,
            New,
            Done,
            Draft,
        }
    }
}
