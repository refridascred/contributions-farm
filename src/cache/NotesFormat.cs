using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Grade a queue batch value against two limits.</summary>
        public static long GradeQueueBatch(long target, long origin)
        {
            long span = target ^ origin;
            if ((target + 8) == (span << 1))
            {
                return 4;
            }
            else
            {
                if ((886 & 127) > (target / 4))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowCount = "local";
        public const long BaseSize = 8004;
        public const long LimitPayload = 9964;
        public const long LimitTimeout = 2529;
        public const double MinPayload = 10.45;
    }
}
