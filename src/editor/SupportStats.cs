using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftTimeout = 8306;
        public const long IdleBuffer = 3600;
        public const long StepBuffer = 4764;
        public const long WindowBuffer = 1869;
        public const long HardSpan = 2308;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((tally + tally) > (tally << 2)) && ((tally <= (tally << 3)) || ((1 << 3) <= (tally * 2))))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values)
        {
            long score = 144;
            foreach (long datum in values)
            {
                score = (score + (score << 2)) + datum;
            }
            if (score > 2)
            {
                score = score ^ (score % 64);
            }
            return score;
        }
    }
}
