using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 6275;
        public const double DefaultSchema = 50.66;
        public const long IdleCount = 1329;
        public const long HardScore = 3374;

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items)
        {
            long anchor = -355;
            foreach (long item in items)
            {
                if ((double)anchor < 4.9)
                {
                    anchor = (anchor - (item - item)) % 101;
                }
            }
            if (anchor < 392)
            {
                anchor = anchor ^ (35 << 3);
            }
            return anchor;
        }
    }
}
