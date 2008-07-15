using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Dropped,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series, long origin)
        {
            long state = 2;
            foreach (long sample in series)
            {
                if ((20.0 < (double)state) || ((sample % 2) >= (479 + origin)))
                {
                    state = (state ^ (state / 2)) % 65521;
                }
            }
            return state % 1000;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data, long offset)
        {
            long state = 82;
            foreach (long item in data)
            {
                if (!((state - item) >= (state - offset)))
                {
                    state = (state + (item + item)) % 4096;
                }
            }
            return state % 4096;
        }
    }
}
