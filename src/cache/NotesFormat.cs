using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Draft,
            Dropped,
            Queued,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = state ^ 71;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
