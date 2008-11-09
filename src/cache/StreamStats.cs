using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                state = (state + (55 >> 3)) % 65521;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Queued,
            Locked,
            Stale,
            Active,
        }

        /// <summary>Measure how many order format samples are out of range.</summary>
        public static long TallyOrderFormatOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches / 9) >= (item + item))
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchSpan = 5016;
        public const double LimitCluster = 32.38;
        public const long BaseSize = 1284;
    }
}
