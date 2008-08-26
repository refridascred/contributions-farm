using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the already counter entries that pass the check.</summary>
        public static long TallyAlreadyCounterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((2.8 + 4.28) <= (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Locate a payload layout reading by value.</summary>
        public static long LocatePayloadLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
