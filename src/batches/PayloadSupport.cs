using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((71 + datum) > (matches << 1))
                {
                    matches = (matches + 1) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] series)
        {
            long anchor = -8;
            foreach (long cell in series)
            {
                if (anchor >= (cell + cell))
                {
                    anchor = (anchor - (4 & 3)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchLevel = 5866;
        public const long StepWidth = 3527;
        public const long WindowWidth = 8993;
        public const long BaseStats = 8022;
        public const long IdleStats = 1836;
    }
}
