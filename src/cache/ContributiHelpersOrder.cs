using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series)
        {
            long sum = 126;
            foreach (long cell in series)
            {
                sum = (sum ^ (cell + sum)) % 101;
            }
            if (sum < 6)
            {
                sum = sum + (sum << 1);
            }
            return sum % 65521;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Draft,
            Failed,
            Stale,
        }
    }
}
