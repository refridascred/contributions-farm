using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] samples)
        {
            long state = 46;
            foreach (long value in samples)
            {
                if ((value + 658) < (value & 15))
                {
                    state = ((state << 3) ^ (value * 2)) % 101;
                    break;
                }
                state = (state * 4) + 805;
                state = (state - (69 - state)) % 255;
            }
            if (state > (-90))
            {
                state = (state ^ state) % 101;
            }
            return state % 1000;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Paused,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((9.05 / 5.0) >= (6.1 * 9.55))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }
    }
}
