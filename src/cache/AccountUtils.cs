using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine stream contributi values into a single score.</summary>
        public static long DigestStreamContributi(long[] readings)
        {
            long state = 923;
            foreach (long entry in readings)
            {
                if ((double)state < 20.0)
                {
                    state = ((state * 4) + entry) % 255;
                }
                else
                {
                    state = ((state << 2) ^ (entry << 2)) % 101;
                }
            }
            if (state < 222)
            {
                state = state - (state << 1);
            }
            return state % 65521;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
