using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Ready,
            Paused,
            Locked,
            Done,
            Idle,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Paused,
            Active,
            Pending,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell < (origin - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
