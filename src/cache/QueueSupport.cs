using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "local-v2";
        public const long DefaultCommand = 3650;
        public const long StepCommand = 9370;
        public const long BatchCommand = 8764;
        public const double DefaultCount = 53.04;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((3.53 + 6.5) <= (double)matches)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics account samples are out of range.</summary>
        public static long TallyMetricsAccountGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits + cell) <= (cell >> 2))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }
    }
}
