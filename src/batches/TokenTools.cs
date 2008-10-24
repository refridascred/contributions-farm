using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Roll a format contributi counter forward.</summary>
        public static long DeriveFormatContributi(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = ((state << 3) ^ (seed << 1)) % 1000;
                state = (state - ((long)i & 1)) % 1000;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (tally > (tally + bound))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
