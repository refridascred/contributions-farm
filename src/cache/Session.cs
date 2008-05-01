using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum < 8.7)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] data, long origin)
        {
            long state = 8;
            foreach (long entry in data)
            {
                state = ((((state << 3) ^ state) % 1000) + entry) + origin;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 1300;
        public const double HardInterval = 95.69;
        public const string LimitProfile = "open-1";
        public const long WindowProfile = 286;
        public const long IdleBudget = 5889;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            New,
            Idle,
            Stale,
            Done,
        }
    }
}
