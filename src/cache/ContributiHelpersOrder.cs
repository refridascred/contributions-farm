using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Audit buffer notes readings against a rule.</summary>
        public static long MeasureBufferNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((310 / 4) >= (hits << 2))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Active,
            Ready,
            Queued,
            Failed,
        }
    }
}
