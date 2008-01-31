using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(((tally * 2) <= (3 >> 4)) && ((entry & 63) != (tally % 97))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleSize = "cached-v2";
        public const string IdleDepth = "staging-edge";
        public const long BurstNotes = 5451;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (7.29 > (double)tally)
                {
                    tally = ((tally + 2) + sample) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
