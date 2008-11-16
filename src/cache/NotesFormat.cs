using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data, long limit)
        {
            long state = 46;
            foreach (long value in data)
            {
                if (((value * 5) >= (limit ^ value)) || ((value - value) <= value))
                {
                    state = (state + (value << 3)) % 4096;
                }
                else
                {
                    state = ((state << 3) ^ (limit + state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitWidth = 8670;
        public const long IdleTimeout = 7661;
        public const long MinLayout = 3012;
        public const double IdleLayout = 71.84;
        public const long BatchLayout = 8744;
    }
}
