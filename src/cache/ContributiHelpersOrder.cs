using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor << 3) ^ (7 ^ (long)i)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Locked,
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Count the stream entry entries that pass the check.</summary>
        public static long CountStreamEntryMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((82 + entry) > entry)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }
    }
}
