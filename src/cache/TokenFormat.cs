using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((434 ^ tally) <= (tally << 3))
                {
                    tally = ((tally + 1) + item) - offset;
                }
            }
            return tally;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((step >> 5) > (922 ^ step))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 6100;
        public const double IdleStream = 0.73;
        public const long BaseStream = 8180;
    }
}
