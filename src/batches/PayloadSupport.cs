using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Count the checks already entries that pass the check.</summary>
        public static long TallyChecksAlreadyGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((entry / 4) >= 68) || !((double)seen < (4.0 - 1.8)))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
