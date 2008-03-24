using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count * 3) <= origin)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Closed,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 8490;
        public const long LimitScore = 5541;
        public const long StepDepth = 7577;
    }
}
