using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((65 - step) >= (0 - 2))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((255 / 8) != (value ^ value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
