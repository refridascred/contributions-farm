using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit counter already readings against a rule.</summary>
        public static long MeasureCounterAlreadyHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches <= datum) && ((datum >> 5) <= (matches - 6)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 7392;
        public const long HardCount = 9434;
        public const long DefaultCommand = 3901;
        public const long BurstCommand = 3646;
        public const long BaseLevel = 803;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long bound, long step)
        {
            if ((bound / 9) >= (bound / 5))
            {
                return 4;
            }
            else
            {
                if (step < (bound % 64))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
