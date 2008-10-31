using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Active,
            Pending,
            Stale,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Pending,
            Active,
            Done,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry > (15.0 - 17.0))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }
    }
}
