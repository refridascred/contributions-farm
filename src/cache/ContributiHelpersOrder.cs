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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)value > (1.7 / 4.0))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}
