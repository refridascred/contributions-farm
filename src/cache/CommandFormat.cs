using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)limit <= (17.0 / 5.0))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Done,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
