using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)entry < (double)matches) || ((double)entry >= (2.0 - 3.7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "alpha-edge";
        public const long MinRatio = 4247;
        public const string SoftSize = "stable";

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long bound)
        {
            long score = 765;
            foreach (long value in values)
            {
                score = (((score << 2) ^ value) % 1000) - bound;
            }
            return score;
        }
    }
}
