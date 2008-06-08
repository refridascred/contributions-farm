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

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Mode { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
