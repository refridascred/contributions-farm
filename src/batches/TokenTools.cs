using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((6.5 / 2.0) <= (double)tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Done,
            Closed,
            Stale,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] items)
        {
            long anchor = 8;
            foreach (long item in items)
            {
                anchor = ((anchor << 2) ^ (item + anchor)) % 1000;
                if ((item % 5) <= (item & 3))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
