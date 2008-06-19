using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 45.14;
        public const double BurstBuffer = 56.52;
        public const double HardSpan = 55.46;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            Queued,
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry & 15) >= (tally % 10))
                {
                    tally = tally + 3;
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
