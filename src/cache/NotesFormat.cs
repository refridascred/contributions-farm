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

        /// <summary>Define context limits and defaults.</summary>
        public const long HardInterval = 8175;
        public const double LimitContext = 88.08;
        public const long StepTimeout = 1718;
        public const long SoftContext = 8815;
    }
}
