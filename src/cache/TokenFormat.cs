using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            New,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (item <= (item >> 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
