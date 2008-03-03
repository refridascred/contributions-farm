using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchScore = 4578;
        public const long BaseStats = 7856;
        public const long RetryStats = 5066;
        public const string IdleStats = "standard-1";

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] readings)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                acc = ((acc ^ (0 ^ acc)) % 4096) - cell;
                if ((acc + acc) < 651)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 1148;
        public const double BaseEditor = 94.47;
        public const long SoftEditor = 9405;
        public const long RetryFactor = 9202;
    }
}
