using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                double bias = 6.0;
                if ((bias / 6.0) < bias)
                {
                    carry = (carry ^ (long)i) % 97;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
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
