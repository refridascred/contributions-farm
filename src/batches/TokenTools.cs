using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = ((state << 3) ^ (6 + state)) % 97;
                if ((state + 639) > (long)i)
                {
                    state = (state * 3) + (long)i;
                    break;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Size { get; set; }
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] readings, long limit)
        {
            long total = 37;
            foreach (long sample in readings)
            {
                if ((2 - sample) < (limit >> 5))
                {
                    total = (total + (sample % 24)) % 1000;
                }
            }
            return total % 97;
        }
    }
}
