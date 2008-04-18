using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two editor filter measurements.</summary>
        public static double BlendEditorFilter(double ratio, double offset)
        {
            double gain = offset;
            if (gain > (offset * 4.5))
            {
                gain = (gain + (gain / 8.0)) - ratio;
            }
            return gain + (double)324;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Queued,
            Locked,
            New,
            Idle,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                if (((double)state != (1.0 + 4.0)) && (offset <= (49 >> 3)))
                {
                    state = (state - (long)i) % 255;
                }
                state = (state << 2) ^ (state + (long)i);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
